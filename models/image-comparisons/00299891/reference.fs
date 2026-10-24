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
            skArc(sketch, "E0", {"start": v(2, -4) * mm, "mid": v(2.24, -1.38) * mm, "end": v(0, 0) * mm});
            skArc(sketch, "E1", {"start": v(8.5, -23.06) * mm, "mid": v(7.82, -12.65) * mm, "end": v(2, -4) * mm});
            skArc(sketch, "E2", {"start": v(8.5, -26.93) * mm, "mid": v(10, -25) * mm, "end": v(8.5, -23.06) * mm});
            skLineSegment(sketch, "E3", {"start": v(8.5, -26.93) * mm, "end": v(7.5, -27.2) * mm});
            skArc(sketch, "E4", {"start": v(7.5, -27.2) * mm, "mid": v(5, -42.75) * mm, "end": v(8, -58.21) * mm});
            skArc(sketch, "E5", {"start": v(10, -60.03) * mm, "mid": v(9.35, -58.73) * mm, "end": v(8, -58.21) * mm});
            skLineSegment(sketch, "E6", {"start": v(10, -60.03) * mm, "end": v(10, -61.03) * mm});
            skArc(sketch, "E7", {"start": v(13, -70) * mm, "mid": v(13.69, -64.78) * mm, "end": v(10, -61.03) * mm});
            skLineSegment(sketch, "E8", {"start": v(13, -70) * mm, "end": v(15, -72) * mm});
            skLineSegment(sketch, "E9", {"start": v(15, -72) * mm, "end": v(15, -75) * mm});
            skLineSegment(sketch, "E10", {"start": v(15, -75) * mm, "end": v(0, -75) * mm});
            skLineSegment(sketch, "E11", {"start": v(0, -75) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E11");
            revolve(context, id + "F1", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
    });