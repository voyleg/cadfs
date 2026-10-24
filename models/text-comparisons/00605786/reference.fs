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
            skCircle(sketch, "E0.cCircle", {"center": v(0, 0) * mm, "radius": 59.38 * mm, "construction": true});
            skLineSegment(sketch, "E0.0", {"start": v(59.38, 0) * mm, "end": v(41.99, -41.99) * mm});
            skLineSegment(sketch, "E0.1", {"start": v(41.99, -41.99) * mm, "end": v(0, -59.38) * mm});
            skLineSegment(sketch, "E0.2", {"start": v(0, -59.38) * mm, "end": v(-41.99, -41.99) * mm});
            skLineSegment(sketch, "E0.3", {"start": v(-41.99, -41.99) * mm, "end": v(-59.38, 0) * mm});
            skLineSegment(sketch, "E0.4", {"start": v(-59.38, 0) * mm, "end": v(-41.99, 41.99) * mm});
            skLineSegment(sketch, "E0.5", {"start": v(-41.99, 41.99) * mm, "end": v(0, 59.38) * mm});
            skLineSegment(sketch, "E0.6", {"start": v(0, 59.38) * mm, "end": v(41.99, 41.99) * mm});
            skLineSegment(sketch, "E0.7", {"start": v(41.99, 41.99) * mm, "end": v(59.38, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F0.wireOp",EDGE,"E0.6");
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0.7");
            var Q2;
            Q2=sQuery(id+"F0.wireOp",EDGE,"E0.2");
            var Q3;
            Q3=sQuery(id+"F0.wireOp",EDGE,"E0.1");
            var Q4;
            Q4=sQuery(id+"F0.wireOp",EDGE,"E0.0");
            var Q5;
            Q5=sQuery(id+"F0.wireOp",EDGE,"E0.3");
            var Q6;
            Q6=sQuery(id+"F0.wireOp",EDGE,"E0.4");
            var Q7;
            Q7=sQuery(id+"F0.wireOp",EDGE,"E0.5");
            extrude(context, id + "F1", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7]), "depth" : 34.28 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 39.04 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F2.wireOp",EDGE,"E1");
            extrude(context, id + "F3", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 35.63 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E2", {"start": v(0, 0) * mm, "end": v(0, 31.8) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F4.wireOp",EDGE,"E2");
            extrude(context, id + "F5", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 36.18 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E3", {"start": v(0, 0) * mm, "end": v(0, 35.21) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F6.wireOp",EDGE,"E3");
            extrude(context, id + "F7", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 37.73 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E4", {"start": v(0, 0) * mm, "end": v(0, 33.96) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F8.wireOp",EDGE,"E4");
            extrude(context, id + "F9", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 39.55 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F10", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5", {"start": v(0, 0) * mm, "end": v(0, 35.07) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F10.wireOp",EDGE,"E5");
            extrude(context, id + "F11", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 39.85 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F12", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E6", {"start": v(39.2, 41.37) * mm, "end": v(27.19, 30.1) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F12.wireOp",EDGE,"E6");
            extrude(context, id + "F13", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 34.66 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F14", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E7", {"start": v(58.88, 0) * mm, "end": v(39.75, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F14.wireOp",EDGE,"E7");
            extrude(context, id + "F15", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 34.22 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F16", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E8", {"start": v(40.84, -41.18) * mm, "end": v(27.66, -27.96) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F16.wireOp",EDGE,"E8");
            extrude(context, id + "F17", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 34.19 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F18", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E9", {"start": v(0, -58.3) * mm, "end": v(0, -39.25) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F18.wireOp",EDGE,"E9");
            extrude(context, id + "F19", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 35.69 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F20", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E10", {"start": v(-41.5, -40.34) * mm, "end": v(-28.04, -27.6) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F20.wireOp",EDGE,"E10");
            extrude(context, id + "F21", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 35.04 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F22", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E11", {"start": v(-58.68, 0) * mm, "end": v(-41.29, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F22.wireOp",EDGE,"E11");
            extrude(context, id + "F23", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "depth" : 35.25 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F24", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E12", {"start": v(-40.76, 41.58) * mm, "end": v(-27.75, 27.76) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F25", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E13", {"start": v(0, 57.57) * mm, "end": v(0, 38.71) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F24.wireOp",EDGE,"E12");
            var Q1;
            Q1=sQuery(id+"F25.wireOp",EDGE,"E13");
            extrude(context, id + "F26", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0, Q1]), "depth" : 35.26 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F27", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E14", {"center": v(0, 0) * mm, "radius": 38.12 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F27.wireOp",EDGE,"E14");
            extrude(context, id + "F28", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 71.01 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F29", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E15", {"center": v(0, 0) * mm, "radius": 5.25 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F29", true);
            extrude(context, id + "F30", {"entities" : qUnion([Q0]), "depth" : 41.45 * mm, "offsetDistance" : 25.4 * mm});
        }
    });