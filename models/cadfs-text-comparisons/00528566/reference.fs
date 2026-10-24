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
            skLineSegment(sketch, "E0", {"start": v(-101.06, 0) * mm, "end": v(98.84, 0) * mm});
            skLineSegment(sketch, "E1.0", {"start": v(-101.06, -0.35) * mm, "end": v(-1.16, -0.35) * mm});
            skLineSegment(sketch, "E2.0", {"start": v(-1.16, -0.3) * mm, "end": v(13.84, -0.3) * mm});
            skLineSegment(sketch, "E3.0", {"start": v(13.84, -0.25) * mm, "end": v(48.84, -0.25) * mm});
            skLineSegment(sketch, "E4", {"start": v(98.84, 0) * mm, "end": v(98.84, -0.23) * mm});
            skLineSegment(sketch, "E5.0", {"start": v(48.84, -0.23) * mm, "end": v(48.84, -0.25) * mm});
            skLineSegment(sketch, "E6.0", {"start": v(13.84, -0.25) * mm, "end": v(13.84, -0.3) * mm});
            skLineSegment(sketch, "E7.trimOffspring", {"start": v(48.84, -0.23) * mm, "end": v(98.84, -0.23) * mm});
            skLineSegment(sketch, "E8.0", {"start": v(-1.16, -0.3) * mm, "end": v(-1.16, -0.35) * mm});
            skLineSegment(sketch, "E9", {"start": v(-101.06, -0.35) * mm, "end": v(-101.06, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0");
            revolve(context, id + "F1", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
    });