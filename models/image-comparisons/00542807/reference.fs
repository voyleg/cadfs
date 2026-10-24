FeatureScript 1549;
import(path : "onshape/std/geometry.fs", version : "1549.0");
import(path : "onshape/std/common.fs", version : "1549.0");
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
            skLineSegment(sketch, "E0", {"start": v(-106.13, 16.72) * mm, "end": v(-0.2, 16.72) * mm, "construction": true});
            skLineSegment(sketch, "E1", {"start": v(-0.2, 29.78) * mm, "end": v(-0.2, 16.72) * mm, "construction": true});
            skArc(sketch, "E2", {"start": v(0, 0) * mm, "mid": v(29.35, 33.43) * mm, "end": v(-7.24, 58.72) * mm});
            skArc(sketch, "E3", {"start": v(-110.25, 33.69) * mm, "mid": v(-123.46, 14.58) * mm, "end": v(-106, -0.74) * mm});
            skLineSegment(sketch, "E4", {"start": v(-110.25, 33.69) * mm, "end": v(-7.24, 58.72) * mm});
            skLineSegment(sketch, "E5", {"start": v(-106, -0.74) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E6", {"center": v(0, 0) * mm, "radius": 3.18 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E6")}),1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E5");
            var Q2;
            Q2=sQuery(id+"F0.wireOp",EDGE,"E3");
            var Q3;
            Q3=sQuery(id+"F0.wireOp",EDGE,"E4");
            var Q4;
            Q4=sQuery(id+"F0.wireOp",EDGE,"E2");
            sweep(context, id + "F2", {"profiles" : qUnion([Q0]), "path" : qUnion([Q1, Q2, Q3, Q4])});
        }
    });