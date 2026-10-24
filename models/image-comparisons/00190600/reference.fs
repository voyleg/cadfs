FeatureScript 2066;
import(path : "onshape/std/geometry.fs", version : "2066.0");
import(path : "onshape/std/common.fs", version : "2066.0");
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
            skLineSegment(sketch, "E0.bottom", {"start": v(-27.12, 78) * mm, "end": v(27.13, 78) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-27.13, -78) * mm, "end": v(27.12, -78) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-41.12, 64) * mm, "end": v(-41.13, -64) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(41.13, 64) * mm, "end": v(41.12, -64) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skPoint(sketch, "E1.visualSharp", {"position": v(-41.12, 78) * mm});
            skArc(sketch, "E1.filletArc", {"start": v(-27.12, 78) * mm, "mid": v(-37.02, 73.9) * mm, "end": v(-41.12, 64) * mm});
            skPoint(sketch, "E2.visualSharp", {"position": v(41.13, 78) * mm});
            skArc(sketch, "E2.filletArc", {"start": v(41.13, 64) * mm, "mid": v(37.02, 73.9) * mm, "end": v(27.13, 78) * mm});
            skPoint(sketch, "E3.visualSharp", {"position": v(41.12, -78) * mm});
            skArc(sketch, "E3.filletArc", {"start": v(27.12, -78) * mm, "mid": v(37.02, -73.9) * mm, "end": v(41.12, -64) * mm});
            skPoint(sketch, "E4.visualSharp", {"position": v(-41.13, -78) * mm});
            skArc(sketch, "E4.filletArc", {"start": v(-41.13, -64) * mm, "mid": v(-37.02, -73.9) * mm, "end": v(-27.13, -78) * mm});
            skLineSegment(sketch, "E5.0", {"start": v(-35.12, 64) * mm, "end": v(-35.13, -64) * mm});
            skLineSegment(sketch, "E5.1", {"start": v(-27.12, 72) * mm, "end": v(27.13, 72) * mm});
            skLineSegment(sketch, "E5.2", {"start": v(35.13, 64) * mm, "end": v(35.12, -64) * mm});
            skLineSegment(sketch, "E5.3", {"start": v(-27.13, -72) * mm, "end": v(27.12, -72) * mm});
            skPoint(sketch, "E6.visualSharp", {"position": v(35.13, 72) * mm});
            skArc(sketch, "E6.filletArc", {"start": v(35.13, 64) * mm, "mid": v(32.78, 69.66) * mm, "end": v(27.13, 72) * mm});
            skPoint(sketch, "E7.visualSharp", {"position": v(35.12, -72) * mm});
            skArc(sketch, "E7.filletArc", {"start": v(27.12, -72) * mm, "mid": v(32.78, -69.66) * mm, "end": v(35.12, -64) * mm});
            skPoint(sketch, "E8.visualSharp", {"position": v(-35.13, -72) * mm});
            skArc(sketch, "E8.filletArc", {"start": v(-35.13, -64) * mm, "mid": v(-32.78, -69.66) * mm, "end": v(-27.13, -72) * mm});
            skPoint(sketch, "E9.visualSharp", {"position": v(-35.12, 72) * mm});
            skArc(sketch, "E9.filletArc", {"start": v(-27.12, 72) * mm, "mid": v(-32.78, 69.66) * mm, "end": v(-35.12, 64) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])],"isStart":false});
            chamfer(context, id + "F2", {"entities" : qUnion([Q0]), "width" : 2 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5.0")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E9.filletArc")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5.1")])],"isStart":false});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6.filletArc")])],"isStart":false});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5.2")])],"isStart":false});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7.filletArc")])],"isStart":false});
            var Q6;
            Q6=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5.3")])],"isStart":false});
            var Q7;
            Q7=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E8.filletArc")])],"isStart":false});
            chamfer(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7]), "width" : 2 * mm, "tangentPropagation" : true});
        }
    });