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
            skCircle(sketch, "E0.cCircle", {"center": v(0, 0) * mm, "radius": 3.85 * mm, "construction": true});
            skLineSegment(sketch, "E0.0", {"start": v(-4.45, 0) * mm, "end": v(-2.22, 3.85) * mm});
            skLineSegment(sketch, "E0.1", {"start": v(-2.22, 3.85) * mm, "end": v(2.22, 3.85) * mm});
            skLineSegment(sketch, "E0.2", {"start": v(2.22, 3.85) * mm, "end": v(4.45, 0) * mm});
            skLineSegment(sketch, "E0.3", {"start": v(4.45, 0) * mm, "end": v(2.22, -3.85) * mm});
            skLineSegment(sketch, "E0.4", {"start": v(2.22, -3.85) * mm, "end": v(-2.22, -3.85) * mm});
            skLineSegment(sketch, "E0.5", {"start": v(-2.22, -3.85) * mm, "end": v(-4.45, 0) * mm});
            skPoint(sketch, "E0.0.midPoint", {"position": v(-3.33, 1.93) * mm});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 2 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.0")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3.7 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.0"),sQuery(id+"F0.wireOp",EDGE,"E0.1"),sQuery(id+"F0.wireOp",EDGE,"E0.2"),sQuery(id+"F0.wireOp",EDGE,"E0.3"),sQuery(id+"F0.wireOp",EDGE,"E0.4"),sQuery(id+"F0.wireOp",EDGE,"E0.5"),sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.0"),sQuery(id+"F0.wireOp",EDGE,"E0.1"),sQuery(id+"F0.wireOp",EDGE,"E0.2"),sQuery(id+"F0.wireOp",EDGE,"E0.3"),sQuery(id+"F0.wireOp",EDGE,"E0.4"),sQuery(id+"F0.wireOp",EDGE,"E0.5"),sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":true});
            chamfer(context, id + "F2", {"entities" : qUnion([Q0, Q1]), "width" : .25 * mm, "tangentPropagation" : true});
        }
    });