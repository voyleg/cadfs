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
            cPlane(context, id + "F0", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F0.planeOp",FACE);
            cPlane(context, id + "F1", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            cPlane(context, id + "F2", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 31.75 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F0.planeOp",FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 38.1 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 12.7 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F2.planeOp",FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E3", {"center": v(0, 0) * mm, "radius": 19.05 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F2.planeOp",FACE);
            cPlane(context, id + "F7", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F7.planeOp",FACE);
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skPoint(sketch, "E4", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F3.wireOp",EDGE,"E0")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E1")}),1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F5.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F5.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F5.wireOp",EDGE,"E2")}),1.0]])]});
            var Q3;
            Q3=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E3")}),1.0]])]});
            var Q4;
            Q4=sQuery(id+"F8.wireOp",VERTEX,"E4");
            loft(context, id + "F9", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }, { "sheetProfileEntities" : qUnion([Q2]) }, { "sheetProfileEntities" : qUnion([Q3]) }, { "sheetProfileEntities" : qUnion([Q4]) }]});
        }
    });