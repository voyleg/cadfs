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
            skLineSegment(sketch, "E0", {"start": v(-23, 24.13) * mm, "end": v(-18, 0) * mm});
            skLineSegment(sketch, "E1", {"start": v(18, 0) * mm, "end": v(23, 24.13) * mm});
            skArc(sketch, "E2", {"start": v(23, 24.13) * mm, "mid": v(0, 30) * mm, "end": v(-23, 24.13) * mm});
            skLineSegment(sketch, "E3", {"start": v(0, 0) * mm, "end": v(-18, 0) * mm});
            skLineSegment(sketch, "E4", {"start": v(0, 0) * mm, "end": v(18, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 5 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5", {"start": v(-4.77, 20.75) * mm, "end": v(5.62, 20.75) * mm});
            skArc(sketch, "E6", {"start": v(-4.77, 20.75) * mm, "mid": v(0.43, 7.25) * mm, "end": v(5.62, 20.75) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.UP_TO_NEXT, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4")])],"isStart":false});
            shell(context, id + "F4", {"entities" : qUnion([Q0]), "thickness" : 2 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E7", {"start": v(0, 0) * mm, "end": v(-7, 0) * mm});
            skLineSegment(sketch, "E8", {"start": v(-7, 0) * mm, "end": v(-7, 3) * mm});
            skLineSegment(sketch, "E9", {"start": v(-7, 3) * mm, "end": v(-5.5, 3) * mm});
            skLineSegment(sketch, "E10", {"start": v(-5.5, 3) * mm, "end": v(-5.5, 2.5) * mm});
            skLineSegment(sketch, "E11", {"start": v(-5.5, 2.5) * mm, "end": v(0, 2.5) * mm});
            skLineSegment(sketch, "E12", {"start": v(0, 2.5) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F5", true);
            var Q1;
            Q1=sQuery(id+"F5.wireOp",EDGE,"E7");
            revolve(context, id + "F6", {"operationType" : NewBodyOperationType.ADD, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.opRevolve","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E8"),sQuery(id+"F5.wireOp",EDGE,"E9")])]});
            chamfer(context, id + "F7", {"entities" : qUnion([Q0]), "width" : 1 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E8")])]});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E13.bottom", {"start": v(25, 2.5) * mm, "end": v(-25, 2.5) * mm});
            skLineSegment(sketch, "E13.top", {"start": v(25, -2.5) * mm, "end": v(-25, -2.5) * mm});
            skLineSegment(sketch, "E13.left", {"start": v(25, 2.5) * mm, "end": v(25, -2.5) * mm});
            skLineSegment(sketch, "E13.right", {"start": v(-25, 2.5) * mm, "end": v(-25, -2.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F8", true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.INTERSECT, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E8")])]});
            var sketch = newSketch(context, id + "F10", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E14.bottom", {"start": v(-1, 6.26) * mm, "end": v(1, 6.26) * mm});
            skLineSegment(sketch, "E14.top", {"start": v(-1, -6.26) * mm, "end": v(1, -6.26) * mm});
            skLineSegment(sketch, "E14.left", {"start": v(-1, 6.26) * mm, "end": v(-1, -6.26) * mm});
            skLineSegment(sketch, "E14.right", {"start": v(1, 6.26) * mm, "end": v(1, -6.26) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F10", true);
            extrude(context, id + "F11", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 6 * mm});
        }
    });