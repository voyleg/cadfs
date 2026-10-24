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
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0.bottom", {"start": v(-682.83, 48.2) * mm, "end": v(688.77, 48.2) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-682.83, 22.8) * mm, "end": v(688.77, 22.8) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-682.83, 48.2) * mm, "end": v(-682.83, 22.8) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(688.77, 48.2) * mm, "end": v(688.77, 22.8) * mm});
            skLineSegment(sketch, "E1", {"start": v(-682.83, 48.2) * mm, "end": v(688.77, 22.8) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3.17 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "radius" : 12.7 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2", {"center": v(-670.13, 35.5) * mm, "radius": 4.8 * mm});
            skCircle(sketch, "E3", {"center": v(676.07, 35.5) * mm, "radius": 4.8 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F3.wireOp",EDGE,"E2")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F3.wireOp",EDGE,"E3")}),1.0]])]});
            var Q2;
            Q2=sQuery(id+"F3.wireOp",EDGE,"E2");
            extrude(context, id + "F4", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.REMOVE, "surfaceEntities" : qUnion([Q2]), "oppositeDirection" : true, "depth" : 3.17 * mm, "offsetDistance" : 25.4 * mm});
        }
    });