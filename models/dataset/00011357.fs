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
            cPlane(context, id + "F0", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 304.8 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 12.7 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F0.planeOp",FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 9.525 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E0")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1")}),1.0]])]});
            loft(context, id + "F3", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }]});
        }
    });