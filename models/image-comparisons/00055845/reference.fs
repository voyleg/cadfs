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
            skLineSegment(sketch, "E0", {"start": v(0, 52.33) * mm, "end": v(0, -42.67) * mm});
            skLineSegment(sketch, "E1", {"start": v(0, 52.33) * mm, "end": v(-21.83, 52.33) * mm});
            skFitSpline(sketch, "E2", {"points": [v(-21.83, 52.33) * mm, v(-14.95, 34.38) * mm, v(-21.83, 12.18) * mm, v(-15.52, -42.67) * mm, v(-15.33, -42.67) * mm], "startDerivative": vector(42.17, -73.9) * mm, "endDerivative": vector(6.63, 4.56) * mm});
            skLineSegment(sketch, "E3", {"start": v(0, -42.67) * mm, "end": v(-15.33, -42.67) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0");
            revolve(context, id + "F1", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])]});
            shell(context, id + "F2", {"entities" : qUnion([Q0]), "thickness" : 2 * mm});
        }
    });