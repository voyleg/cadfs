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
            skArc(sketch, "E0", {"start": v(-8.22, 42.7) * mm, "mid": v(-37.66, 21.74) * mm, "end": v(-41.09, -14.23) * mm});
            skArc(sketch, "E1", {"start": v(8.22, 63.8) * mm, "mid": v(0, 72) * mm, "end": v(-8.22, 63.8) * mm});
            skLineSegment(sketch, "E2", {"start": v(-8.22, 63.8) * mm, "end": v(-8.22, 42.7) * mm});
            skLineSegment(sketch, "E3", {"start": v(8.22, 63.8) * mm, "end": v(8.22, 42.7) * mm});
            skLineSegment(sketch, "E4.1.0", {"start": v(-59.35, -24.78) * mm, "end": v(-41.09, -14.23) * mm});
            skArc(sketch, "E4.1.1", {"start": v(-59.35, -24.78) * mm, "mid": v(-62.36, -36) * mm, "end": v(-51.14, -39.01) * mm});
            skLineSegment(sketch, "E4.1.2", {"start": v(-51.14, -39.01) * mm, "end": v(-32.87, -28.47) * mm});
            skLineSegment(sketch, "E4.2.0", {"start": v(51.14, -39.01) * mm, "end": v(32.87, -28.47) * mm});
            skArc(sketch, "E4.2.1", {"start": v(51.14, -39.01) * mm, "mid": v(62.36, -36) * mm, "end": v(59.35, -24.78) * mm});
            skLineSegment(sketch, "E4.2.2", {"start": v(59.35, -24.78) * mm, "end": v(41.09, -14.23) * mm});
            skArc(sketch, "E5.trimOffspring", {"start": v(-32.87, -28.47) * mm, "mid": v(0, -43.48) * mm, "end": v(32.87, -28.47) * mm});
            skArc(sketch, "E6.trimOffspring", {"start": v(41.09, -14.23) * mm, "mid": v(37.66, 21.74) * mm, "end": v(8.22, 42.7) * mm});
            skCircle(sketch, "E7", {"center": v(0, 63.8) * mm, "radius": 5.84 * mm});
            skCircle(sketch, "E8.1.0", {"center": v(-55.25, -31.9) * mm, "radius": 5.84 * mm});
            skCircle(sketch, "E8.2.0", {"center": v(55.25, -31.9) * mm, "radius": 5.84 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4.1.0"),sQuery(id+"F0.wireOp",EDGE,"E4.1.1"),sQuery(id+"F0.wireOp",EDGE,"E4.1.2"),sQuery(id+"F0.wireOp",EDGE,"E4.2.0"),sQuery(id+"F0.wireOp",EDGE,"E4.2.1"),sQuery(id+"F0.wireOp",EDGE,"E4.2.2"),sQuery(id+"F0.wireOp",EDGE,"E5.trimOffspring"),sQuery(id+"F0.wireOp",EDGE,"E6.trimOffspring"),sQuery(id+"F0.wireOp",EDGE,"E7"),sQuery(id+"F0.wireOp",EDGE,"E8.1.0"),sQuery(id+"F0.wireOp",EDGE,"E8.2.0")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E9", {"center": v(0, 0) * mm, "radius": 38.91 * mm});
            skCircle(sketch, "E10", {"center": v(0, 0) * mm, "radius": 34.22 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E9")}),1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 20 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.boolean.opBoolean","SPLIT",FACE,{"disambiguationData":[TD([makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E10")])]})])],"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4.1.0"),sQuery(id+"F0.wireOp",EDGE,"E4.1.1"),sQuery(id+"F0.wireOp",EDGE,"E4.1.2"),sQuery(id+"F0.wireOp",EDGE,"E4.2.0"),sQuery(id+"F0.wireOp",EDGE,"E4.2.1"),sQuery(id+"F0.wireOp",EDGE,"E4.2.2"),sQuery(id+"F0.wireOp",EDGE,"E5.trimOffspring"),sQuery(id+"F0.wireOp",EDGE,"E6.trimOffspring"),sQuery(id+"F0.wireOp",EDGE,"E7"),sQuery(id+"F0.wireOp",EDGE,"E8.1.0"),sQuery(id+"F0.wireOp",EDGE,"E8.2.0")])],"isStart":false})});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E11", {"center": v(0, 0) * mm, "radius": 14.89 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E11")}),1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E4.2.2");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E4.2.0");var subQ2=sQuery(id+"F0.wireOp",EDGE,"E8.2.0");var subQ3=sQuery(id+"F0.wireOp",EDGE,"E4.1.2");var subQ4=sQuery(id+"F0.wireOp",EDGE,"E4.1.1");var subQ5=sQuery(id+"F0.wireOp",EDGE,"E4.1.0");var subQ6=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ7=sQuery(id+"F0.wireOp",EDGE,"E4.2.1");var subQ8=sQuery(id+"F0.wireOp",EDGE,"E1");var subQ9=sQuery(id+"F0.wireOp",EDGE,"E2");var subQ10=sQuery(id+"F0.wireOp",EDGE,"E3");var subQ11=sQuery(id+"F0.wireOp",EDGE,"E5.trimOffspring");var subQ12=sQuery(id+"F0.wireOp",EDGE,"E6.trimOffspring");var subQ13=sQuery(id+"F0.wireOp",EDGE,"E7");var subQ14=sQuery(id+"F0.wireOp",EDGE,"E8.1.0");Q0=makeQuery(id+"F3.boolean.opBoolean","SPLIT",FACE,{"disambiguationData":[TD([makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ6])]})])],"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([subQ6,subQ8,subQ9,subQ10,subQ5,subQ4,subQ3,subQ1,subQ7,subQ0,subQ11,subQ12,subQ13,subQ14,subQ2])],"isStart":false})});}
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E12", {"center": v(0, 63.8) * mm, "radius": 7.37 * mm});
            skCircle(sketch, "E13.1.0", {"center": v(-55.25, -31.9) * mm, "radius": 7.37 * mm});
            skCircle(sketch, "E13.2.0", {"center": v(55.25, -31.9) * mm, "radius": 7.37 * mm});
            skPoint(sketch, "E13.center", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E12")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E13.2.0")}),1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E13.1.0")}),1.0]])]});
            extrude(context, id + "F7", {"entities" : qUnion([Q0, Q1, Q2]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 3 * mm});
        }
    });