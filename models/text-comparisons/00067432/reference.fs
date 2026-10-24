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
            skLineSegment(sketch, "E0.rect.bottom", {"start": v(4, -1) * mm, "end": v(3.46, -1) * mm});
            skLineSegment(sketch, "E0.rect.top", {"start": v(4, 1) * mm, "end": v(-4, 1) * mm});
            skLineSegment(sketch, "E0.rect.left", {"start": v(4, -1) * mm, "end": v(4, 1) * mm});
            skLineSegment(sketch, "E0.rect.right", {"start": v(-4, -1) * mm, "end": v(-4, 1) * mm});
            skPoint(sketch, "E0.rect.middle", {"position": v(0, 0) * mm});
            skArc(sketch, "E1", {"start": v(-3.46, -1) * mm, "mid": v(-3.98, -3.4) * mm, "end": v(-3, -5.65) * mm});
            skLineSegment(sketch, "E2.left", {"start": v(-3, -5.65) * mm, "end": v(-3, -15) * mm});
            skLineSegment(sketch, "E2.right", {"start": v(4, -3) * mm, "end": v(4, -15) * mm});
            skLineSegment(sketch, "E3.bottom", {"start": v(-3, -15) * mm, "end": v(-4.83, -15) * mm});
            skLineSegment(sketch, "E3.top", {"start": v(4, -17.67) * mm, "end": v(-4.83, -17.67) * mm});
            skLineSegment(sketch, "E3.left", {"start": v(4, -15) * mm, "end": v(4, -17.67) * mm});
            skLineSegment(sketch, "E3.right", {"start": v(-4.83, -15) * mm, "end": v(-4.83, -17.67) * mm});
            skCircle(sketch, "E4", {"center": v(0, -13.57) * mm, "radius": 1 * mm});
            skLineSegment(sketch, "E5.trimOffspring", {"start": v(-3.46, -1) * mm, "end": v(-4, -1) * mm});
            skArc(sketch, "E6.trimOffspring", {"start": v(4, -3) * mm, "mid": v(3.86, -1.96) * mm, "end": v(3.46, -1) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 15 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E7", {"center": v(0, -13.57) * mm, "radius": 10.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.SYMMETRIC, "oppositeDirection" : true, "depth" : 1.5 * mm});
        }
    });