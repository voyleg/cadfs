FeatureScript 1549;
import(path : "onshape/std/geometry.fs", version : "1549.0");
import(path : "onshape/std/common.fs", version : "1549.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 30 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 5 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1.bottom", {"start": v(2.5, 23.52) * mm, "end": v(-2.5, 23.52) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(2.5, 36.52) * mm, "end": v(-2.5, 36.52) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(2.5, 23.52) * mm, "end": v(2.5, 36.52) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(-2.5, 23.52) * mm, "end": v(-2.5, 36.52) * mm});
            skPoint(sketch, "E1.middle", {"position": v(0, 30.02) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1.bottom")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "depth" : 5 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1.top"),sQuery(id+"F2.wireOp",EDGE,"E1.right")])]});
            var Q1;
            Q1=makeQuery(id+"F3.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1.top"),sQuery(id+"F2.wireOp",EDGE,"E1.left")])]});
            fillet(context, id + "F4", {"entities" : qUnion([Q0, Q1]), "radius" : 2 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1.bottom"),sQuery(id+"F2.wireOp",EDGE,"E1.top"),sQuery(id+"F2.wireOp",EDGE,"E1.left"),sQuery(id+"F2.wireOp",EDGE,"E1.right")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            circularPattern(context, id + "F5", {"entities" : qUnion([Q0, Q1]), "axis" : qUnion([Q2]), "angle" : 360 * degree, "instanceCount" : 15, "equalSpace" : true});
        }
    });