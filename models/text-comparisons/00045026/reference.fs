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
            skCircle(sketch, "E0", {"center": v(-863.6, -508) * mm, "radius": 25.4 * mm});
            skLineSegment(sketch, "E1", {"start": v(-313.64, 0) * mm, "end": v(330.7, 0) * mm, "construction": true});
            skLineSegment(sketch, "E2", {"start": v(0, 280.45) * mm, "end": v(0, -274.4) * mm, "construction": true});
            skCircle(sketch, "E3.MirrorC", {"center": v(863.6, -508) * mm, "radius": 25.4 * mm});
            skCircle(sketch, "E4.MirrorC", {"center": v(-863.6, 508) * mm, "radius": 25.4 * mm});
            skCircle(sketch, "E5.MirrorC", {"center": v(863.6, 508) * mm, "radius": 25.4 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 76.2 * mm, "hasDraft" : true, "draftAngle" : 3 * degree});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E6.bottom", {"start": v(-939.8, -584.2) * mm, "end": v(939.8, -584.2) * mm});
            skLineSegment(sketch, "E6.top", {"start": v(-939.8, 584.2) * mm, "end": v(939.8, 584.2) * mm});
            skLineSegment(sketch, "E6.left", {"start": v(-939.8, -584.2) * mm, "end": v(-939.8, 584.2) * mm});
            skLineSegment(sketch, "E6.right", {"start": v(939.8, -584.2) * mm, "end": v(939.8, 584.2) * mm});
            skPoint(sketch, "E7", {"position": v(0, -584.2) * mm});
            skPoint(sketch, "E8", {"position": v(939.8, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "depth" : 526.76 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E6.bottom"),sQuery(id+"F2.wireOp",EDGE,"E6.top"),sQuery(id+"F2.wireOp",EDGE,"E6.left"),sQuery(id+"F2.wireOp",EDGE,"E6.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E9.bottom", {"start": v(-939.8, 584.2) * mm, "end": v(939.8, 584.2) * mm});
            skLineSegment(sketch, "E9.top", {"start": v(-939.8, 330.2) * mm, "end": v(939.8, 330.2) * mm});
            skLineSegment(sketch, "E9.left", {"start": v(-939.8, 584.2) * mm, "end": v(-939.8, 330.2) * mm});
            skLineSegment(sketch, "E9.right", {"start": v(939.8, 584.2) * mm, "end": v(939.8, 330.2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 914.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E6.bottom"),sQuery(id+"F2.wireOp",EDGE,"E6.top"),sQuery(id+"F2.wireOp",EDGE,"E6.left"),sQuery(id+"F2.wireOp",EDGE,"E6.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E10.bottom", {"start": v(-939.8, -584.2) * mm, "end": v(-787.4, -584.2) * mm});
            skLineSegment(sketch, "E10.top", {"start": v(-939.8, 330.2) * mm, "end": v(-787.4, 330.2) * mm});
            skLineSegment(sketch, "E10.left", {"start": v(-939.8, -584.2) * mm, "end": v(-939.8, 330.2) * mm});
            skLineSegment(sketch, "E10.right", {"start": v(-787.4, -584.2) * mm, "end": v(-787.4, 330.2) * mm});
            skLineSegment(sketch, "E11.bottom", {"start": v(939.8, -584.2) * mm, "end": v(787.4, -584.2) * mm});
            skLineSegment(sketch, "E11.top", {"start": v(939.8, 330.2) * mm, "end": v(787.4, 330.2) * mm});
            skLineSegment(sketch, "E11.left", {"start": v(939.8, -584.2) * mm, "end": v(939.8, 330.2) * mm});
            skLineSegment(sketch, "E11.right", {"start": v(787.4, -584.2) * mm, "end": v(787.4, 330.2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F6", true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 381 * mm});
        }
    });