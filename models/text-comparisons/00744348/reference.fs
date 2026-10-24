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
            skLineSegment(sketch, "E0.bottom", {"start": v(0, 0) * mm, "end": v(55.54, 0) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(0, 30) * mm, "end": v(55.54, 30) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(0, 0) * mm, "end": v(0, 30) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(55.54, 0) * mm, "end": v(55.54, 30) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 35 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 30 * mm, "offsetDistance" : 25 * mm, "hasDraft" : true, "draftAngle" : 5 * degree, "draftPullDirection" : true});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 15.59) * mm, "radius": 12.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F3",true);
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 50 * mm, "offsetDistance" : 25 * mm, "hasDraft" : true, "draftAngle" : 6 * degree});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E2", {"start": v(66.8, 2.92) * mm, "end": v(125.26, 5.47) * mm});
            skLineSegment(sketch, "E3", {"start": v(66.8, -2.92) * mm, "end": v(125.26, -5.47) * mm});
            skLineSegment(sketch, "E4", {"start": v(66.8, -2.92) * mm, "end": v(66.8, 2.92) * mm});
            skLineSegment(sketch, "E5", {"start": v(125.26, -5.47) * mm, "end": v(125.26, 5.47) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E6.left", {"start": v(55.54, 15) * mm, "end": v(55.54, 30) * mm});
            skArc(sketch, "E7", {"start": v(115.54, 0) * mm, "mid": v(89.08, 22.08) * mm, "end": v(55.54, 30) * mm});
            skArc(sketch, "E8", {"start": v(115.54, 0) * mm, "mid": v(86.46, 11.2) * mm, "end": v(55.54, 15) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F6", true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 35 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F5", true);
            extrude(context, id + "F8", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "depth" : 40 * mm, "offsetDistance" : 25 * mm});
        }
    });