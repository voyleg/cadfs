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
            skLineSegment(sketch, "E0.bottom", {"start": v(-13.8, 49.18) * mm, "end": v(41.07, 49.18) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-13.8, -78.08) * mm, "end": v(41.07, -78.08) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-22.8, 40.18) * mm, "end": v(-22.8, -69.08) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(50.07, 40.18) * mm, "end": v(50.07, -69.08) * mm});
            skPoint(sketch, "E1.visualSharp", {"position": v(-22.8, 49.18) * mm});
            skArc(sketch, "E1.filletArc", {"start": v(-13.8, 49.18) * mm, "mid": v(-20.17, 46.55) * mm, "end": v(-22.8, 40.18) * mm});
            skPoint(sketch, "E2.visualSharp", {"position": v(50.07, 49.18) * mm});
            skArc(sketch, "E2.filletArc", {"start": v(50.07, 40.18) * mm, "mid": v(47.43, 46.55) * mm, "end": v(41.07, 49.18) * mm});
            skPoint(sketch, "E3.visualSharp", {"position": v(-22.8, -78.08) * mm});
            skArc(sketch, "E3.filletArc", {"start": v(-22.8, -69.08) * mm, "mid": v(-20.17, -75.44) * mm, "end": v(-13.8, -78.08) * mm});
            skPoint(sketch, "E4.visualSharp", {"position": v(50.07, -78.08) * mm});
            skArc(sketch, "E4.filletArc", {"start": v(41.07, -78.08) * mm, "mid": v(47.43, -75.44) * mm, "end": v(50.07, -69.08) * mm});
            skLineSegment(sketch, "E5.bottom", {"start": v(-17.8, 35.18) * mm, "end": v(45.07, 35.18) * mm});
            skLineSegment(sketch, "E5.top", {"start": v(-17.8, -62.08) * mm, "end": v(45.07, -62.08) * mm});
            skLineSegment(sketch, "E5.left", {"start": v(-17.8, 35.18) * mm, "end": v(-17.8, -62.08) * mm});
            skLineSegment(sketch, "E5.right", {"start": v(45.07, 35.18) * mm, "end": v(45.07, -62.08) * mm});
            skCircle(sketch, "E6", {"center": v(13.17, -70.4) * mm, "radius": 6.4 * mm});
            skCircle(sketch, "E7", {"center": v(2.97, 42.35) * mm, "radius": 2.04 * mm});
            skLineSegment(sketch, "E8.bottom", {"start": v(7.5, 42.35) * mm, "end": v(22.24, 42.35) * mm});
            skLineSegment(sketch, "E8.top", {"start": v(7.5, 41.5) * mm, "end": v(22.24, 41.5) * mm});
            skLineSegment(sketch, "E8.left", {"start": v(7.5, 42.35) * mm, "end": v(7.5, 41.5) * mm});
            skLineSegment(sketch, "E8.right", {"start": v(22.24, 42.35) * mm, "end": v(22.24, 41.5) * mm});
            skFitSpline(sketch, "E9", {"points": [v(-5.38, 49.18) * mm, v(-13.8, 80.47) * mm, v(0, 96.2) * mm, v(6.05, 49.18) * mm, v(7, 49.18) * mm], "startDerivative": vector(-53.3, 94.42) * mm, "endDerivative": vector(19.1, 12.94) * mm});
            skFitSpline(sketch, "E10", {"points": [v(22.25, 49.18) * mm, v(23.2, 77.62) * mm, v(38.93, 93.81) * mm, v(45.6, 72.37) * mm, v(35.11, 49.18) * mm, v(36.07, 49.18) * mm], "startDerivative": vector(-15.66, 110.74) * mm, "endDerivative": vector(27.65, 7.77) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 7 * mm, "offsetDistance" : 25 * mm});
        }
    });