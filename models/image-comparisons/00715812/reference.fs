FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
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
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 11.1 * mm});
            skCircle(sketch, "E1", {"center": v(27.2, 0) * mm, "radius": 11.1 * mm});
            skCircle(sketch, "E2.MirrorC", {"center": v(-27.2, 0) * mm, "radius": 11.1 * mm});
            skArc(sketch, "E3", {"start": v(-27.2, 19.1) * mm, "mid": v(-46.3, 0) * mm, "end": v(-27.2, -19.1) * mm});
            skArc(sketch, "E4.MirrorCS", {"start": v(27.2, 19.1) * mm, "mid": v(46.3, 0) * mm, "end": v(27.2, -19.1) * mm});
            skLineSegment(sketch, "E5", {"start": v(-27.2, 19.1) * mm, "end": v(27.2, 19.1) * mm});
            skLineSegment(sketch, "E6.MirrorCS", {"start": v(-27.2, -19.1) * mm, "end": v(27.2, -19.1) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 6 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6.MirrorCS")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5")])],"isStart":true});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1]), "radius" : 2 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2.MirrorC")])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2.MirrorC")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":true});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":false});
            fillet(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5]), "radius" : 1 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });