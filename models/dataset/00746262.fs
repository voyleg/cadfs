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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 8.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 16 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 10.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 1.5 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 10.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 7.5 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E2")])],"isStart":false});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E3", {"center": v(0, 0) * mm, "radius": 4 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F6", true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E2")])],"isStart":true});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E4", {"center": v(0, 0) * mm, "radius": 8.5 * mm, "construction": true});
            skLineSegment(sketch, "E5", {"start": v(0, 0) * mm, "end": v(0, 8.5) * mm, "construction": true});
            skCircle(sketch, "E6", {"center": v(0, 8.5) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.1.0", {"center": v(-2.9071712182681844, 7.987387276680223) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.2.0", {"center": v(-5.463694682335584, 6.5113777665113135) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.3.0", {"center": v(-7.361215932167728, 4.25) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.4.0", {"center": v(-8.370865900603768, 1.4760095101689086) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.5.0", {"center": v(-8.370865900603768, -1.4760095101689077) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.6.0", {"center": v(-7.361215932167729, -4.25) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.7.0", {"center": v(-5.4636946823355865, -6.511377766511313) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.8.0", {"center": v(-2.9071712182681857, -7.987387276680221) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.9.0", {"center": v(0, -8.5) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.10.0", {"center": v(2.907171218268184, -7.987387276680223) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.11.0", {"center": v(5.463694682335581, -6.511377766511317) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.12.0", {"center": v(7.361215932167727, -4.25) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.13.0", {"center": v(8.370865900603768, -1.476009510168908) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.14.0", {"center": v(8.37086590060377, 1.4760095101689048) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.15.0", {"center": v(7.361215932167733, 4.25) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.16.0", {"center": v(5.463694682335587, 6.511377766511312) * mm, "radius": 0.9 * mm});
            skCircle(sketch, "E7.17.0", {"center": v(2.9071712182681835, 7.987387276680223) * mm, "radius": 0.9 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F8", true);
            var Q1;
            Q1=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1")])],"isStart":true});
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.UP_TO_SURFACE, "depth" : 25 * mm, "endBoundEntityFace" : qUnion([Q1]), "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1")])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F5.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E2")])],"isStart":true});
            chamfer(context, id + "F10", {"entities" : qUnion([Q0, Q1]), "width" : 1 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E2")])],"isStart":false});
            chamfer(context, id + "F11", {"entities" : qUnion([Q0, Q1]), "width" : 0.2 * mm, "tangentPropagation" : true});
        }
    });