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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 98.425 * mm, "construction": true});
            skCircle(sketch, "E1", {"center": v(0, 98.425) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E2.1.0", {"center": v(-69.59698493828596, 69.59698493828596) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E2.2.0", {"center": v(-98.425, 0) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E2.3.0", {"center": v(-69.59698493828596, -69.59698493828596) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E2.4.0", {"center": v(0, -98.425) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E2.5.0", {"center": v(69.59698493828596, -69.59698493828596) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E2.6.0", {"center": v(98.425, 0) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E2.7.0", {"center": v(69.59698493828596, 69.59698493828596) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E3", {"center": v(0, 0) * mm, "radius": 76.2 * mm});
            skCircle(sketch, "E4", {"center": v(0, 0) * mm, "radius": 114.3 * mm});
            skCircle(sketch, "E5", {"center": v(0, 0) * mm, "radius": 82.55 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E6", {"start": v(0, 0) * mm, "end": v(0, 50.8) * mm});
            skLineSegment(sketch, "E7", {"start": v(101.6, 152.4) * mm, "end": v(152.4, 152.4) * mm});
            skPoint(sketch, "E8.visualSharp", {"position": v(0, 152.4) * mm});
            skArc(sketch, "E8.filletArc", {"start": v(101.6, 152.4) * mm, "mid": v(29.75795103144678, 122.64204896855324) * mm, "end": v(0, 50.8) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E3")}),-1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1")}),-1.0]])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0, Q1]), "depth" : 12.7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E3")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F1.wireOp",EDGE,"E6");
            var Q2;
            Q2=sQuery(id+"F1.wireOp",EDGE,"E8.filletArc");
            var Q3;
            Q3=sQuery(id+"F1.wireOp",EDGE,"E7");
            sweep(context, id + "F3", {"operationType" : NewBodyOperationType.ADD, "profiles" : qUnion([Q0]), "path" : qUnion([Q1, Q2, Q3])});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opSweep","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E5"),sQuery(id+"F1.wireOp",VERTEX,"E7.end")])],"isStart":false});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E9", {"center": v(152.4, 0) * mm, "radius": 98.425 * mm, "construction": true});
            skCircle(sketch, "E10", {"center": v(152.4, 98.425) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E11.1.0", {"center": v(82.80301506171405, 69.59698493828596) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E11.2.0", {"center": v(53.975, 0) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E11.3.0", {"center": v(82.80301506171406, -69.59698493828597) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E11.4.0", {"center": v(152.4, -98.425) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E11.5.0", {"center": v(221.996984938286, -69.59698493828597) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E11.6.0", {"center": v(250.825, 0) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E11.7.0", {"center": v(221.99698493828595, 69.59698493828597) * mm, "radius": 9.525 * mm});
            skCircle(sketch, "E12", {"center": v(152.4, 0) * mm, "radius": 76.2 * mm});
            skCircle(sketch, "E13", {"center": v(152.4, 0) * mm, "radius": 114.3 * mm});
            skCircle(sketch, "E14", {"center": v(152.4, 0) * mm, "radius": 82.55 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E12")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E10")}),-1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.ADD, "depth" : 12.7 * mm});
        }
    });