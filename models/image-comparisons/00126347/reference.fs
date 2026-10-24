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
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(0, 9) * mm});
            skLineSegment(sketch, "E1", {"start": v(0, 9) * mm, "end": v(-11, 9) * mm});
            skLineSegment(sketch, "E2", {"start": v(0, 0) * mm, "end": v(105, 0) * mm});
            skLineSegment(sketch, "E3", {"start": v(105, 0) * mm, "end": v(105, 9) * mm});
            skLineSegment(sketch, "E4", {"start": v(105, 9) * mm, "end": v(116, 9) * mm});
            skArc(sketch, "E5", {"start": v(18, 38) * mm, "mid": v(-2.5, 29.5) * mm, "end": v(-11, 9) * mm});
            skArc(sketch, "E6", {"start": v(116, 9) * mm, "mid": v(107.5, 29.5) * mm, "end": v(87, 38) * mm});
            skLineSegment(sketch, "E7", {"start": v(18, 38) * mm, "end": v(87, 38) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 58 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E8", {"start": v(14, -4) * mm, "end": v(33, -4) * mm});
            skArc(sketch, "E9", {"start": v(14, 4) * mm, "mid": v(10, 0) * mm, "end": v(14, -4) * mm});
            skLineSegment(sketch, "E10", {"start": v(14, 4) * mm, "end": v(33, 4) * mm});
            skArc(sketch, "E11", {"start": v(33, -4) * mm, "mid": v(37, 0) * mm, "end": v(33, 4) * mm});
            skLineSegment(sketch, "E12", {"start": v(64, -4) * mm, "end": v(83, -4) * mm});
            skArc(sketch, "E13", {"start": v(64, 4) * mm, "mid": v(60, 0) * mm, "end": v(64, -4) * mm});
            skLineSegment(sketch, "E14", {"start": v(64, 4) * mm, "end": v(83, 4) * mm});
            skArc(sketch, "E15", {"start": v(83, -4) * mm, "mid": v(87, 0) * mm, "end": v(83, 4) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E16", {"start": v(18, 27) * mm, "end": v(-18, 27) * mm});
            skLineSegment(sketch, "E17", {"start": v(-18, 38) * mm, "end": v(18, 38) * mm});
            skLineSegment(sketch, "E18", {"start": v(18, 38) * mm, "end": v(18, 27) * mm});
            skLineSegment(sketch, "E19", {"start": v(-18, 38) * mm, "end": v(-18, 27) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F5", true);
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F6.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E17"),sQuery(id+"F5.wireOp",EDGE,"E19")])]})});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6")])],"isStart":true});
            var Q2;
            Q2=makeQuery(id+"F6.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F6.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E17"),sQuery(id+"F5.wireOp",EDGE,"E18")])]})});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7")])],"isStart":false});
            fillet(context, id + "F7", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "radius" : 3 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });