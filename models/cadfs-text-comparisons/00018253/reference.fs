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
            skFitSpline(sketch, "E0", {"points": [v(0, 0) * mm, v(0.7, 5.01) * mm, v(14.12, 6.63) * mm], "startDerivative": vector(-1.9, 15.22) * mm, "endDerivative": vector(27.76, -0.68) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1.cCircle", {"center": v(0, 0) * mm, "radius": 1.25 * mm, "construction": true});
            skLineSegment(sketch, "E1.0", {"start": v(0, -1.25) * mm, "end": v(-0.88, -0.88) * mm});
            skLineSegment(sketch, "E1.1", {"start": v(-0.88, -0.88) * mm, "end": v(-1.25, 0) * mm});
            skLineSegment(sketch, "E1.2", {"start": v(-1.25, 0) * mm, "end": v(-0.88, 0.88) * mm});
            skLineSegment(sketch, "E1.3", {"start": v(-0.88, 0.88) * mm, "end": v(0, 1.25) * mm});
            skLineSegment(sketch, "E1.4", {"start": v(0, 1.25) * mm, "end": v(0.88, 0.88) * mm});
            skLineSegment(sketch, "E1.5", {"start": v(0.88, 0.88) * mm, "end": v(1.25, 0) * mm});
            skLineSegment(sketch, "E1.6", {"start": v(1.25, 0) * mm, "end": v(0.88, -0.88) * mm});
            skLineSegment(sketch, "E1.7", {"start": v(0.88, -0.88) * mm, "end": v(0, -1.25) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E1.0")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0");
            sweep(context, id + "F2", {"profiles" : qUnion([Q0]), "path" : qUnion([Q1])});
        }
    });