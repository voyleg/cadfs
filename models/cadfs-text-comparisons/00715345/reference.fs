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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 22.23 * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 35.05 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F1",true);
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 5.84 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F1.wireOp",EDGE,"E2")])],"isStart":false});
            chamfer(context, id + "F3", {"entities" : qUnion([Q0]), "chamferType" : ChamferType.OFFSET_ANGLE, "width" : 2.54 * mm, "oppositeDirection" : false, "angle" : 70 * degree, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F1.wireOp",EDGE,"E1"),sQuery(id+"F1.wireOp",EDGE,"E2")])],"isStart":false});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E3", {"center": v(0, 0) * mm, "radius": 28.07 * mm});
            skCircle(sketch, "E4", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F4",true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2.54 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E3"),sQuery(id+"F4.wireOp",EDGE,"E4")])],"isStart":false});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E5", {"center": v(0, 0) * mm, "radius": 26.55 * mm});
            skCircle(sketch, "E6", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F6",true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2.54 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F7.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E5"),sQuery(id+"F6.wireOp",EDGE,"E6")])],"isStart":false});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E7", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skCircle(sketch, "E8", {"center": v(0, 0) * mm, "radius": 25.4 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F8",true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 65.28 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F9.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F8.wireOp",EDGE,"E7"),sQuery(id+"F8.wireOp",EDGE,"E8")])],"isStart":false});
            var sketch = newSketch(context, id + "F10", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E9", {"center": v(0, 0) * mm, "radius": 27.94 * mm});
            skCircle(sketch, "E10", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F11", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E11", {"start": v(76.2, 0) * mm, "end": v(5867.4, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F10",true);
            var Q1;
            Q1=qConstructionFilter(qBodyType(qCreatedBy(id+"F11",EDGE),BodyType.WIRE),ConstructionObject.NO);
            sweep(context, id + "F12", {"operationType" : NewBodyOperationType.ADD, "profiles" : qUnion([Q0]), "path" : qUnion([Q1])});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F12.opSweep","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F10.wireOp",EDGE,"E9"),sQuery(id+"F10.wireOp",EDGE,"E10"),sQuery(id+"F11.wireOp",VERTEX,"7ykRA0Qg-2DrY-rTCa-7tXY-ZQoEE0Xzwcjr.end")])],"isStart":false});
            var sketch = newSketch(context, id + "F13", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E12", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skCircle(sketch, "E13", {"center": v(0, 0) * mm, "radius": 25.4 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F12.opSweep","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F10.wireOp",EDGE,"E9"),sQuery(id+"F11.wireOp",VERTEX,"7ykRA0Qg-2DrY-rTCa-7tXY-ZQoEE0Xzwcjr.end")])],"isStart":false});
            fillet(context, id + "F14", {"entities" : qUnion([Q0]), "radius" : 1.27 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F13",true);
            extrude(context, id + "F15", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 76.2 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F15.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F13.wireOp",EDGE,"E12"),sQuery(id+"F13.wireOp",EDGE,"E13")])],"isStart":false});
            var sketch = newSketch(context, id + "F16", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E14", {"center": v(0, 0) * mm, "radius": 35.05 * mm});
            skCircle(sketch, "E15", {"center": v(0, 0) * mm, "radius": 22.86 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F16",true);
            extrude(context, id + "F17", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 5.84 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F17.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F16.wireOp",EDGE,"E14")])],"isStart":false});
            chamfer(context, id + "F18", {"entities" : qUnion([Q0]), "chamferType" : ChamferType.OFFSET_ANGLE, "width" : 2.54 * mm, "oppositeDirection" : false, "angle" : 70 * degree, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F17.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F16.wireOp",EDGE,"E14"),sQuery(id+"F16.wireOp",EDGE,"E15")])],"isStart":false});
            var sketch = newSketch(context, id + "F19", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E16", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skCircle(sketch, "E17", {"center": v(0, 0) * mm, "radius": 28.07 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F19",true);
            extrude(context, id + "F20", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2.54 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F20.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F19.wireOp",EDGE,"E16"),sQuery(id+"F19.wireOp",EDGE,"E17")])],"isStart":false});
            var sketch = newSketch(context, id + "F21", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E18", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skCircle(sketch, "E19", {"center": v(0, 0) * mm, "radius": 26.8 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F21",true);
            extrude(context, id + "F22", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2.54 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F17.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F15.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F13.wireOp",EDGE,"E12"),sQuery(id+"F13.wireOp",EDGE,"E13")])],"isStart":false}),makeQuery(id+"F17.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F16.wireOp",EDGE,"E14"),sQuery(id+"F16.wireOp",EDGE,"E15")])],"isStart":true})]});
            var sketch = newSketch(context, id + "F23", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E20", {"center": v(0, 0) * mm, "radius": 10.16 * mm});
            skCircle(sketch, "E21", {"center": v(0, 0) * mm, "radius": 24.13 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F23",true);
            extrude(context, id + "F24", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 304.8 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F24.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F23.wireOp",EDGE,"E20"),sQuery(id+"F23.wireOp",EDGE,"E21")])],"isStart":false});
            var sketch = newSketch(context, id + "F25", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E22", {"center": v(0, 0) * mm, "radius": 10.67 * mm});
            skCircle(sketch, "E23", {"center": v(0, 0) * mm, "radius": 7.87 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F25",true);
            extrude(context, id + "F26", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 25.4 * mm, "offsetDistance" : 25.4 * mm});
        }
    });