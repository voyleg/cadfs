FeatureScript 1758;
import(path : "onshape/std/geometry.fs", version : "1758.0");
import(path : "onshape/std/common.fs", version : "1758.0");
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
            skArc(sketch, "E0", {"start": v(11.93, -3) * mm, "mid": v(0, 12.3) * mm, "end": v(-11.93, -3) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(0, -30) * mm, "end": v(0, -30) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(-3.5, -0.88) * mm, "end": v(-3.5, -26.5) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(3.5, 0) * mm, "end": v(3.5, -26.5) * mm});
            skLineSegment(sketch, "E2", {"start": v(-7.73, -3) * mm, "end": v(7.83, -3) * mm, "construction": true});
            skLineSegment(sketch, "E3", {"start": v(7.83, -3) * mm, "end": v(15.22, -3) * mm});
            skLineSegment(sketch, "E4", {"start": v(-7.73, -3) * mm, "end": v(-15.27, -3) * mm});
            skLineSegment(sketch, "E5", {"start": v(-11.93, -3) * mm, "end": v(-3.5, -0.88) * mm});
            skLineSegment(sketch, "E6", {"start": v(11.93, -3) * mm, "end": v(3.5, -0.88) * mm});
            skPoint(sketch, "E7.visualSharp", {"position": v(-3.5, -30) * mm});
            skArc(sketch, "E7.filletArc", {"start": v(-3.5, -26.5) * mm, "mid": v(-2.47, -28.97) * mm, "end": v(0, -30) * mm});
            skPoint(sketch, "E8.visualSharp", {"position": v(3.5, -30) * mm});
            skArc(sketch, "E8.filletArc", {"start": v(0, -30) * mm, "mid": v(2.47, -28.97) * mm, "end": v(3.5, -26.5) * mm});
            skCircle(sketch, "E9", {"center": v(0, -26.5) * mm, "radius": 1.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 2.5 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E6")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E5")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.left"),sQuery(id+"F0.wireOp",EDGE,"E5")])]});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.right"),sQuery(id+"F0.wireOp",EDGE,"E6")])]});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "radius" : 1.5 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1.left"),sQuery(id+"F0.wireOp",EDGE,"E1.right"),sQuery(id+"F0.wireOp",EDGE,"E5"),sQuery(id+"F0.wireOp",EDGE,"E6"),sQuery(id+"F0.wireOp",EDGE,"E7.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E8.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E9")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1.left"),sQuery(id+"F0.wireOp",EDGE,"E1.right"),sQuery(id+"F0.wireOp",EDGE,"E5"),sQuery(id+"F0.wireOp",EDGE,"E6"),sQuery(id+"F0.wireOp",EDGE,"E7.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E8.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E9")])],"isStart":true});
            chamfer(context, id + "F3", {"entities" : qUnion([Q0, Q1]), "width" : 0.5 * mm, "tangentPropagation" : true});
        }
    });