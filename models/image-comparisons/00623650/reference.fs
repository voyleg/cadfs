FeatureScript 2625;
import(path : "onshape/std/geometry.fs", version : "2625.0");
import(path : "onshape/std/common.fs", version : "2625.0");
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
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(0, 59.65) * mm, "construction": true});
            skLineSegment(sketch, "E1", {"start": v(-10.25, 8) * mm, "end": v(-10.25, 40.5) * mm});
            skLineSegment(sketch, "E2", {"start": v(-10.25, 40.5) * mm, "end": v(-9.25, 40.5) * mm});
            skLineSegment(sketch, "E3", {"start": v(10.25, 40.5) * mm, "end": v(10.25, 8) * mm});
            skLineSegment(sketch, "E4", {"start": v(-10.25, 8) * mm, "end": v(10.25, 8) * mm});
            skPoint(sketch, "E5", {"position": v(0, 40.5) * mm});
            skPoint(sketch, "E6", {"position": v(-9.25, 40.5) * mm});
            skPoint(sketch, "E7", {"position": v(9.25, 40.5) * mm});
            skPoint(sketch, "E8", {"position": v(0, 33.17) * mm});
            skArc(sketch, "E9.converted", {"start": v(-9.25, 40.5) * mm, "mid": v(0, 33.17) * mm, "end": v(9.25, 40.5) * mm});
            skLineSegment(sketch, "E10.trimOffspring", {"start": v(9.25, 40.5) * mm, "end": v(10.25, 40.5) * mm});
            skLineSegment(sketch, "E11", {"start": v(-0.3, 0) * mm, "end": v(21.8, 0) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E11");
            revolve(context, id + "F1", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
    });