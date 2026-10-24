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
            skLineSegment(sketch, "E0.bottom", {"start": v(5, 3.5) * mm, "end": v(-5, 3.5) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(5, -3.5) * mm, "end": v(-5, -3.5) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(5, 3.5) * mm, "end": v(5, -3.5) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-5, 3.5) * mm, "end": v(-5, -3.5) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 15 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 2.77 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 5 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1")])],"isStart":false});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 1.46 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])],"isStart":false});
            var Q6;
            Q6=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top")])],"isStart":false});
            var Q7;
            Q7=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q8;
            Q8=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":true});
            fillet(context, id + "F6", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8]), "radius" : 1 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":true});
            var sketch = newSketch(context, id + "F7", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E3", {"start": v(0, 1.5) * mm, "end": v(3.45, 1.5) * mm});
            skLineSegment(sketch, "E4", {"start": v(3.45, 1.5) * mm, "end": v(3.45, 0.65) * mm});
            skLineSegment(sketch, "E5", {"start": v(3.45, 0.65) * mm, "end": v(2.9, -0.15) * mm});
            skLineSegment(sketch, "E6", {"start": v(2.9, -0.15) * mm, "end": v(2.9, -1.5) * mm});
            skLineSegment(sketch, "E7", {"start": v(2.9, -1.5) * mm, "end": v(0, -1.5) * mm});
            skLineSegment(sketch, "E8", {"start": v(0, -1.5) * mm, "end": v(0, 1.5) * mm, "construction": true});
            skPoint(sketch, "E9", {"position": v(0, 0) * mm});
            skLineSegment(sketch, "E10.MirrorCS", {"start": v(-3.45, 0.65) * mm, "end": v(-2.9, -0.15) * mm});
            skLineSegment(sketch, "E11.MirrorCS", {"start": v(-2.9, -1.5) * mm, "end": v(0, -1.5) * mm});
            skLineSegment(sketch, "E12.MirrorCS", {"start": v(-2.9, -0.15) * mm, "end": v(-2.9, -1.5) * mm});
            skLineSegment(sketch, "E13.MirrorCS", {"start": v(0, 1.5) * mm, "end": v(-3.45, 1.5) * mm});
            skLineSegment(sketch, "E14.MirrorCS", {"start": v(-3.45, 1.5) * mm, "end": v(-3.45, 0.65) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F7", true);
            extrude(context, id + "F8", {"entities" : qUnion([Q0]), "depth" : 7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E13.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E14.MirrorCS")])]});
            var Q1;
            Q1=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E3"),sQuery(id+"F7.wireOp",EDGE,"E4")])]});
            var Q2;
            Q2=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E4"),sQuery(id+"F7.wireOp",EDGE,"E5")])]});
            var Q3;
            Q3=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E5"),sQuery(id+"F7.wireOp",EDGE,"E6")])]});
            var Q4;
            Q4=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E6"),sQuery(id+"F7.wireOp",EDGE,"E7")])]});
            var Q5;
            Q5=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E11.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E12.MirrorCS")])]});
            var Q6;
            Q6=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E10.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E12.MirrorCS")])]});
            var Q7;
            Q7=makeQuery(id+"F8.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E10.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E14.MirrorCS")])]});
            fillet(context, id + "F9", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7]), "radius" : 0.5 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F8.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E3"),sQuery(id+"F7.wireOp",EDGE,"E4"),sQuery(id+"F7.wireOp",EDGE,"E5"),sQuery(id+"F7.wireOp",EDGE,"E6"),sQuery(id+"F7.wireOp",EDGE,"E7"),sQuery(id+"F7.wireOp",EDGE,"E10.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E11.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E12.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E13.MirrorCS"),sQuery(id+"F7.wireOp",EDGE,"E14.MirrorCS")])],"isStart":false});
            shell(context, id + "F10", {"entities" : qUnion([Q0]), "thickness" : 0.4 * mm});
        }
    });