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
            skLineSegment(sketch, "E0.bottom", {"start": v(40, 22.5) * mm, "end": v(-40, 22.5) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(40, -22.5) * mm, "end": v(-40, -22.5) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(40, 22.5) * mm, "end": v(40, -22.5) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-40, 22.5) * mm, "end": v(-40, -22.5) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 20 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top")])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])],"isStart":true});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])],"isStart":true});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":true});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "radius" : 3 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            fillet(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "radius" : 10 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            shell(context, id + "F4", {"entities" : qUnion([Q0]), "thickness" : 2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1", {"start": v(-12.5, 11.5) * mm, "end": v(12.5, 11.5) * mm, "construction": true});
            skLineSegment(sketch, "E2.bottom", {"start": v(6, 13.75) * mm, "end": v(-6, 13.75) * mm});
            skLineSegment(sketch, "E2.top", {"start": v(6, 9.25) * mm, "end": v(-6, 9.25) * mm});
            skLineSegment(sketch, "E2.left", {"start": v(6, 13.75) * mm, "end": v(6, 9.25) * mm});
            skLineSegment(sketch, "E2.right", {"start": v(-6, 13.75) * mm, "end": v(-6, 9.25) * mm});
            skPoint(sketch, "E2.middle", {"position": v(0, 11.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F5.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F5.wireOp",EDGE,"E2.bottom")}),1.0]])]});
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 2 * mm, "offsetDistance" : 25 * mm});
        }
    });