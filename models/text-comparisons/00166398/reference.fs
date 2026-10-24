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
            skCircle(sketch, "E0", {"center": v(-14, 14) * mm, "radius": 1.8 * mm});
            skCircle(sketch, "E1", {"center": v(14, 14) * mm, "radius": 1.8 * mm});
            skCircle(sketch, "E2", {"center": v(14, -14) * mm, "radius": 1.8 * mm});
            skCircle(sketch, "E3", {"center": v(-14, -14) * mm, "radius": 1.8 * mm});
            skArc(sketch, "E4", {"start": v(-17, -14) * mm, "mid": v(-16.12, -16.12) * mm, "end": v(-14, -17) * mm});
            skArc(sketch, "E5", {"start": v(14, -17) * mm, "mid": v(16.12, -16.12) * mm, "end": v(17, -14) * mm});
            skLineSegment(sketch, "E6", {"start": v(17, 14) * mm, "end": v(17, -14) * mm});
            skLineSegment(sketch, "E7", {"start": v(14, -17) * mm, "end": v(-14, -17) * mm});
            skLineSegment(sketch, "E8", {"start": v(-17, 14) * mm, "end": v(-17, -14) * mm});
            skLineSegment(sketch, "E9", {"start": v(0, -15.43) * mm, "end": v(0, 3.26) * mm});
            skPoint(sketch, "E9.startSnap0", {"position": v(0, -17) * mm});
            skLineSegment(sketch, "E10.0", {"start": v(10, 2.5) * mm, "end": v(-10, 2.5) * mm});
            skLineSegment(sketch, "E11.0", {"start": v(-11, 14) * mm, "end": v(-11, 3.5) * mm});
            skLineSegment(sketch, "E12.0", {"start": v(11, 14) * mm, "end": v(11, 3.5) * mm});
            skArc(sketch, "E13", {"start": v(-11, 14) * mm, "mid": v(-14, 17) * mm, "end": v(-17, 14) * mm});
            skArc(sketch, "E14", {"start": v(17, 14) * mm, "mid": v(14, 17) * mm, "end": v(11, 14) * mm});
            skArc(sketch, "E15.filletArc", {"start": v(-11, 3.5) * mm, "mid": v(-10.7, 2.8) * mm, "end": v(-10, 2.5) * mm});
            skArc(sketch, "E16.filletArc", {"start": v(10, 2.5) * mm, "mid": v(10.7, 2.8) * mm, "end": v(11, 3.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 1 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E17", {"start": v(0, 0) * mm, "end": v(-17, 0) * mm});
            skLineSegment(sketch, "E18", {"start": v(-17, 0) * mm, "end": v(-17, 6.7) * mm});
            skArc(sketch, "E19", {"start": v(-15, 4.73) * mm, "mid": v(-15.96, 4.28) * mm, "end": v(-15.5, 3.32) * mm});
            skArc(sketch, "E20", {"start": v(-6.76, 0.14) * mm, "mid": v(-5.8, 0.59) * mm, "end": v(-6.25, 1.55) * mm});
            skPoint(sketch, "E21.visualSharp", {"position": v(-17, 7.06) * mm});
            skLineSegment(sketch, "E22.trimOffspring", {"start": v(-15, 4.73) * mm, "end": v(-6.25, 1.55) * mm});
            skLineSegment(sketch, "E23.trimOffspring", {"start": v(-15.5, 3.32) * mm, "end": v(-6.76, 0.14) * mm});
            skLineSegment(sketch, "E24", {"start": v(2.4, 0) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E25.0", {"start": v(-15.66, 7.63) * mm, "end": v(2.4, 1.06) * mm});
            skLineSegment(sketch, "E26", {"start": v(2.4, 0) * mm, "end": v(2.4, 1.06) * mm});
            skPoint(sketch, "E27.visualSharp", {"position": v(-17, 8.12) * mm});
            skArc(sketch, "E27.filletArc", {"start": v(-15.66, 7.63) * mm, "mid": v(-16.57, 7.51) * mm, "end": v(-17, 6.7) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E17")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "endBound" : BoundingType.SYMMETRIC, "depth" : 21 * mm});
        }
    });