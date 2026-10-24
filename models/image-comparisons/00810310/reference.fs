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
            cPlane(context, id + "F0", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 100 * mm, "width" : 150 * mm, "height" : 150 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0.bottom", {"start": v(-47.5, 42.3) * mm, "end": v(47.5, 42.3) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-47.5, -42.3) * mm, "end": v(47.5, -42.3) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-47.5, 42.3) * mm, "end": v(-47.5, -42.3) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(47.5, 42.3) * mm, "end": v(47.5, -42.3) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F0.planeOp",FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 64.75 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E0.bottom")}),-1.0]])]});
            loft(context, id + "F3", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }]});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opLoft","CAP_FACE",FACE,{"disambiguationData":[OSD([makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1")}),1.0]])]})])],"isStart":true});
            shell(context, id + "F4", {"entities" : qUnion([Q0]), "thickness" : 2.5 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opLoft","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F1.wireOp",EDGE,"E0.top"),sQuery(id+"F1.wireOp",EDGE,"E0.left"),sQuery(id+"F1.wireOp",EDGE,"E0.right"),sQuery(id+"F2.wireOp",EDGE,"E1")])]});
            var Q1;
            Q1=makeQuery(id+"F3.opLoft","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F1.wireOp",EDGE,"E0.bottom"),sQuery(id+"F1.wireOp",EDGE,"E0.top"),sQuery(id+"F1.wireOp",EDGE,"E0.right"),sQuery(id+"F2.wireOp",EDGE,"E1")])]});
            var Q2;
            Q2=makeQuery(id+"F3.opLoft","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F1.wireOp",EDGE,"E0.bottom"),sQuery(id+"F1.wireOp",EDGE,"E0.left")])]});
            var Q3;
            Q3=makeQuery(id+"F3.opLoft","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F1.wireOp",EDGE,"E0.bottom"),sQuery(id+"F1.wireOp",EDGE,"E0.left"),sQuery(id+"F1.wireOp",EDGE,"E0.right"),sQuery(id+"F2.wireOp",EDGE,"E1")])]});
            chamfer(context, id + "F5", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "width" : 5 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skFitSpline(sketch, "E2", {"points": [v(28.6, 76.62) * mm, v(104.69, 46.28) * mm, v(94.84, 12.17) * mm, v(31.93, 9.45) * mm, v(32.65, 8.03) * mm], "startDerivative": vector(261.97, -52.24) * mm, "endDerivative": vector(32.44, -32.03) * mm});
            skSolve(sketch);
        }
    });