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
            skArc(sketch, "E0", {"start": v(-25, -5.21) * mm, "mid": v(-14.52, -17.8) * mm, "end": v(-3, -6.16) * mm});
            skArc(sketch, "E1", {"start": v(-3.57, -2.52) * mm, "mid": v(-15.4, 5) * mm, "end": v(-25, -5.21) * mm});
            skArc(sketch, "E2", {"start": v(0, -1) * mm, "mid": v(-2.02, -1.2) * mm, "end": v(-3.57, -2.52) * mm});
            skArc(sketch, "E3.MirrorCS", {"start": v(25, -5.21) * mm, "mid": v(14.52, -17.8) * mm, "end": v(3, -6.16) * mm});
            skArc(sketch, "E4.MirrorCS", {"start": v(3.57, -2.52) * mm, "mid": v(15.4, 5) * mm, "end": v(25, -5.21) * mm});
            skArc(sketch, "E5.MirrorCS", {"start": v(0, -1) * mm, "mid": v(2.02, -1.2) * mm, "end": v(3.57, -2.52) * mm});
            skArc(sketch, "E6", {"start": v(3, -6.16) * mm, "mid": v(0, -3.72) * mm, "end": v(-3, -6.16) * mm});
            skCircle(sketch, "E7", {"center": v(-14.03, -5.9) * mm, "radius": 9 * mm});
            skCircle(sketch, "E8", {"center": v(14.03, -5.9) * mm, "radius": 9 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 1.3 * mm});
        }
    });