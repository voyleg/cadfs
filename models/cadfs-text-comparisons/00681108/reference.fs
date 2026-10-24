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
            skText(sketch, "E0", { "text": "Stefan", "fontName": "OpenSans-Bold.ttf"});
            const initialGuessF0  = {"E0": [-0.07315, 0.00208, 1, 0, 0.02692]};
            skSetInitialGuess(sketch, initialGuessF0);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1.bottom", {"start": v(-73.15, 2.33) * mm, "end": v(44.85, 2.33) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(-73.15, 0) * mm, "end": v(44.85, 0) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(-73.15, 2.33) * mm, "end": v(-73.15, 0) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(44.85, 2.33) * mm, "end": v(44.85, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E2", {"start": v(-82.21, -6.73) * mm, "end": v(80.32, -6.73) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            var Q1;
            Q1=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E1.bottom")}),-1.0]])]});
            var Q2;
            Q2=sQuery(id+"F2.wireOp",EDGE,"E2");
            revolve(context, id + "F3", {"entities" : qUnion([Q0, Q1]), "axis" : qUnion([Q2]), "revolveType" : RevolveType.ONE_DIRECTION, "angle" : 60 * degree});
        }
    });