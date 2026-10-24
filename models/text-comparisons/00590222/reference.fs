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
            skCircle(sketch, "E0", {"center": v(-31.67, 40.93) * mm, "radius": 19.7 * mm});
            skCircle(sketch, "E1", {"center": v(-39.67, 45.93) * mm, "radius": 5 * mm});
            skCircle(sketch, "E2", {"center": v(-23.67, 45.93) * mm, "radius": 5 * mm});
            skArc(sketch, "E3", {"start": v(-39.67, 35.63) * mm, "mid": v(-31.66, 27.64) * mm, "end": v(-23.67, 35.66) * mm});
            skArc(sketch, "E4", {"start": v(-39.67, 35.63) * mm, "mid": v(-31.67, 32.93) * mm, "end": v(-23.67, 35.66) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 5 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E2")}),1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E3")}),1.0]])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2]), "operationType" : NewBodyOperationType.ADD, "depth" : 3 * mm, "offsetDistance" : 25 * mm});
        }
    });