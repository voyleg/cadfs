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
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 4.78 * mm});
            skArc(sketch, "E1", {"start": v(-9.723256473003532, -1.0519902852189011) * mm, "mid": v(-5.447384982791247, -8.1224624867869) * mm, "end": v(2.7168769639631867, -9.395050801495763) * mm});
            skLineSegment(sketch, "E2", {"start": v(0, 9.78) * mm, "end": v(-22.23, 9.78) * mm});
            skLineSegment(sketch, "E3", {"start": v(-22.23, 9.78) * mm, "end": v(-22.23, 4.78) * mm});
            skLineSegment(sketch, "E4", {"start": v(-22.23, 4.78) * mm, "end": v(-9.72325647300353, -1.0519902852189098) * mm});
            skLineSegment(sketch, "E5", {"start": v(9.78, 0) * mm, "end": v(28.58, 0) * mm});
            skLineSegment(sketch, "E6", {"start": v(28.58, 0) * mm, "end": v(28.58, -5) * mm});
            skLineSegment(sketch, "E7", {"start": v(28.58, -5) * mm, "end": v(2.716876963963189, -9.39505080149576) * mm});
            skArc(sketch, "E8.trimOffspring", {"start": v(9.78, 0) * mm, "mid": v(6.915504320004435, 6.915504320004433) * mm, "end": v(0, 9.78) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 19 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6")])],"isStart":false});
            chamfer(context, id + "F2", {"entities" : qUnion([Q0, Q1]), "chamferType" : ChamferType.TWO_OFFSETS, "width1" : 7.62 * mm, "oppositeDirection" : false, "width2" : 2.54 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6")])],"isStart":true});
            chamfer(context, id + "F3", {"entities" : qUnion([Q0, Q1]), "chamferType" : ChamferType.TWO_OFFSETS, "width1" : 2.54 * mm, "oppositeDirection" : false, "width2" : 7.62 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E9", {"start": v(5.08, 6.35) * mm, "end": v(5.08, -3.81) * mm});
            skLineSegment(sketch, "E10", {"start": v(-5.08, 6.35) * mm, "end": v(-5.08, -3.81) * mm});
            skArc(sketch, "E11", {"start": v(-5.08, 6.35) * mm, "mid": v(0, 11.43) * mm, "end": v(5.08, 6.35) * mm});
            skArc(sketch, "E12", {"start": v(-5.08, -3.81) * mm, "mid": v(0, -8.89) * mm, "end": v(5.08, -3.81) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F4",true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 50.8 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : false, "secondDirectionDepth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E13.rect.bottom", {"start": v(-4.765, 28.58) * mm, "end": v(4.765, 28.58) * mm});
            skLineSegment(sketch, "E13.rect.top", {"start": v(-4.765, 19.05) * mm, "end": v(4.765, 19.05) * mm});
            skLineSegment(sketch, "E13.rect.left", {"start": v(-4.765, 28.58) * mm, "end": v(-4.765, 19.05) * mm});
            skLineSegment(sketch, "E13.rect.right", {"start": v(4.765, 28.58) * mm, "end": v(4.765, 19.05) * mm});
            skPoint(sketch, "E13.rect.middle", {"position": v(0, 23.815) * mm});
            skLineSegment(sketch, "E14.rect.bottom", {"start": v(-4.765, -22.23) * mm, "end": v(4.765, -22.23) * mm});
            skLineSegment(sketch, "E14.rect.top", {"start": v(-4.765, -12.7) * mm, "end": v(4.765, -12.7) * mm});
            skLineSegment(sketch, "E14.rect.left", {"start": v(-4.765, -22.23) * mm, "end": v(-4.765, -12.7) * mm});
            skLineSegment(sketch, "E14.rect.right", {"start": v(4.765, -22.23) * mm, "end": v(4.765, -12.7) * mm});
            skPoint(sketch, "E14.rect.middle", {"position": v(0, -17.465) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F6",true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25.4 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : false, "secondDirectionDepth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E15", {"center": v(-19.69, 7.24) * mm, "radius": 1.5875 * mm});
            skCircle(sketch, "E16", {"center": v(26.04, -2.54) * mm, "radius": 1.59 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F8",true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25.4 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : false, "secondDirectionDepth" : 25.4 * mm});
        }
    });