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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 2.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 50 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E1", {"start": v(17.5, 0) * mm, "mid": v(8.75, 8.75) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E2", {"start": v(17.5, 0) * mm, "end": v(17.5, -9.77) * mm});
            skArc(sketch, "E3", {"start": v(17.5, -9.77) * mm, "mid": v(15.76, -16.31) * mm, "end": v(17.5, -22.86) * mm});
            skLineSegment(sketch, "E4", {"start": v(17.5, -22.86) * mm, "end": v(15.2, -39.17) * mm});
            skArc(sketch, "E5", {"start": v(15.2, -39.17) * mm, "mid": v(14.9, -43.6) * mm, "end": v(15.2, -48.04) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E6", {"center": v(0, 0) * mm, "radius": 2.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F3.wireOp",EDGE,"E6")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F2.wireOp",EDGE,"E1");
            var Q2;
            Q2=sQuery(id+"F2.wireOp",EDGE,"E2");
            var Q3;
            Q3=sQuery(id+"F2.wireOp",EDGE,"E3");
            var Q4;
            Q4=sQuery(id+"F2.wireOp",EDGE,"E4");
            var Q5;
            Q5=sQuery(id+"F2.wireOp",EDGE,"E5");
            sweep(context, id + "F4", {"operationType" : NewBodyOperationType.ADD, "profiles" : qUnion([Q0]), "path" : qUnion([Q1, Q2, Q3, Q4, Q5])});
        }
    });