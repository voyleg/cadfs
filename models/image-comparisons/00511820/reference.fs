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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 18.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 35 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            shell(context, id + "F2", {"entities" : qUnion([Q0]), "thickness" : 1 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 18.5) * mm, "radius": 1.04 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F3.wireOp",EDGE,"E1");var subQ1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});var subQ2=makeQuery(id+"F3.imprint","INTERSECT",VERTEX,{"disambiguationData":[OD(0.0)],"derivedFrom":[subQ1,subQ0]});Q0=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"disambiguationData":[TD([[subQ2,1.0]])],"derivedFrom":subQ0}),1.0]])]});}
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 33.7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])]});
            circularPattern(context, id + "F5", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "angle" : 360 * degree, "instanceCount" : 40, "equalSpace" : true});
        }
    });