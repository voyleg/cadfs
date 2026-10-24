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
            skLineSegment(sketch, "E0.bottom", {"start": v(0, 0) * mm, "end": v(-1016, 0) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(0, 1016) * mm, "end": v(-1016, 1016) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(0, 0) * mm, "end": v(0, 1016) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-1016, 0) * mm, "end": v(-1016, 1016) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 19.05 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1", {"start": v(0, 711.2) * mm, "end": v(-1016, 0) * mm});
            skLineSegment(sketch, "E2", {"start": v(-1016, 0) * mm, "end": v(-705.95, 0) * mm});
            skLineSegment(sketch, "E3", {"start": v(-705.95, 0) * mm, "end": v(0, 494.17) * mm});
            skLineSegment(sketch, "E4", {"start": v(0, 494.17) * mm, "end": v(0, 711.2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1")}),1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 19.05 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5", {"start": v(0, 711.2) * mm, "end": v(1016, 0) * mm});
            skLineSegment(sketch, "E6", {"start": v(1016, 0) * mm, "end": v(705.95, 0) * mm});
            skLineSegment(sketch, "E7", {"start": v(705.95, 0) * mm, "end": v(0, 494.17) * mm});
            skLineSegment(sketch, "E8", {"start": v(0, 494.17) * mm, "end": v(0, 711.2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F4.wireOp",EDGE,"E6");Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":subQ0}),-1.0]])]});}
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 19.05 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1"),sQuery(id+"F2.wireOp",EDGE,"E2"),sQuery(id+"F2.wireOp",EDGE,"E3"),sQuery(id+"F2.wireOp",EDGE,"E4")])],"isStart":false});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E9.bottom", {"start": v(146.05, 556.76) * mm, "end": v(209.55, 556.76) * mm});
            skLineSegment(sketch, "E9.top", {"start": v(146.05, 537.71) * mm, "end": v(209.55, 537.71) * mm});
            skLineSegment(sketch, "E9.left", {"start": v(146.05, 556.76) * mm, "end": v(146.05, 537.71) * mm});
            skLineSegment(sketch, "E9.right", {"start": v(209.55, 556.76) * mm, "end": v(209.55, 537.71) * mm});
            skLineSegment(sketch, "E10.bottom", {"start": v(336.55, 467.86) * mm, "end": v(273.05, 467.86) * mm});
            skLineSegment(sketch, "E10.top", {"start": v(336.55, 448.81) * mm, "end": v(273.05, 448.81) * mm});
            skLineSegment(sketch, "E10.left", {"start": v(336.55, 467.86) * mm, "end": v(336.55, 448.81) * mm});
            skLineSegment(sketch, "E10.right", {"start": v(273.05, 467.86) * mm, "end": v(273.05, 448.81) * mm});
            skLineSegment(sketch, "E11.bottom", {"start": v(463.55, 378.96) * mm, "end": v(400.05, 378.96) * mm});
            skLineSegment(sketch, "E11.top", {"start": v(463.55, 359.91) * mm, "end": v(400.05, 359.91) * mm});
            skLineSegment(sketch, "E11.left", {"start": v(463.55, 378.96) * mm, "end": v(463.55, 359.91) * mm});
            skLineSegment(sketch, "E11.right", {"start": v(400.05, 378.96) * mm, "end": v(400.05, 359.91) * mm});
            skLineSegment(sketch, "E12.bottom", {"start": v(590.55, 290.06) * mm, "end": v(527.05, 290.06) * mm});
            skLineSegment(sketch, "E12.top", {"start": v(590.55, 271.01) * mm, "end": v(527.05, 271.01) * mm});
            skLineSegment(sketch, "E12.left", {"start": v(590.55, 290.06) * mm, "end": v(590.55, 271.01) * mm});
            skLineSegment(sketch, "E12.right", {"start": v(527.05, 290.06) * mm, "end": v(527.05, 271.01) * mm});
            skLineSegment(sketch, "E13.bottom", {"start": v(717.55, 201.16) * mm, "end": v(654.05, 201.16) * mm});
            skLineSegment(sketch, "E13.top", {"start": v(717.55, 182.11) * mm, "end": v(654.05, 182.11) * mm});
            skLineSegment(sketch, "E13.left", {"start": v(717.55, 201.16) * mm, "end": v(717.55, 182.11) * mm});
            skLineSegment(sketch, "E13.right", {"start": v(654.05, 201.16) * mm, "end": v(654.05, 182.11) * mm});
            skLineSegment(sketch, "E14.bottom", {"start": v(844.55, 112.26) * mm, "end": v(781.05, 112.26) * mm});
            skLineSegment(sketch, "E14.top", {"start": v(844.55, 93.21) * mm, "end": v(781.05, 93.21) * mm});
            skLineSegment(sketch, "E14.left", {"start": v(844.55, 112.26) * mm, "end": v(844.55, 93.21) * mm});
            skLineSegment(sketch, "E14.right", {"start": v(781.05, 112.26) * mm, "end": v(781.05, 93.21) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E10.bottom")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E9.bottom")}),-1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E11.bottom")}),1.0]])]});
            var Q3;
            Q3=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E12.bottom")}),1.0]])]});
            var Q4;
            Q4=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E13.bottom")}),1.0]])]});
            var Q5;
            Q5=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E14.bottom")}),1.0]])]});
            extrude(context, id + "F7", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5]), "operationType" : NewBodyOperationType.ADD, "endBound" : BoundingType.UP_TO_NEXT, "depth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1"),sQuery(id+"F2.wireOp",EDGE,"E2"),sQuery(id+"F2.wireOp",EDGE,"E3"),sQuery(id+"F2.wireOp",EDGE,"E4")])],"isStart":false});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E15.bottom", {"start": v(19.05, 480.83) * mm, "end": v(38.1, 480.83) * mm});
            skLineSegment(sketch, "E15.top", {"start": v(19.05, 569.73) * mm, "end": v(38.1, 569.73) * mm});
            skLineSegment(sketch, "E15.left", {"start": v(19.05, 480.83) * mm, "end": v(19.05, 569.73) * mm});
            skLineSegment(sketch, "E15.right", {"start": v(38.1, 480.83) * mm, "end": v(38.1, 569.73) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F8.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F8.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F8.wireOp",EDGE,"E15.bottom")}),1.0]])]});
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "endBound" : BoundingType.UP_TO_NEXT, "depth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F7.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E9.bottom")])]});
            var sketch = newSketch(context, id + "F10", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E16", {"center": v(-812.8, -177.8) * mm, "radius": 4.76 * mm});
            skCircle(sketch, "E17", {"center": v(-660.4, -177.8) * mm, "radius": 4.76 * mm});
            skCircle(sketch, "E18", {"center": v(-508, -177.8) * mm, "radius": 4.76 * mm});
            skCircle(sketch, "E19", {"center": v(-355.6, -177.8) * mm, "radius": 4.76 * mm});
            skCircle(sketch, "E20", {"center": v(-203.2, -177.8) * mm, "radius": 4.76 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F10.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F10.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F10.wireOp",EDGE,"E16")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F10.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F10.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F10.wireOp",EDGE,"E17")}),1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F10.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F10.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F10.wireOp",EDGE,"E18")}),1.0]])]});
            var Q3;
            Q3=makeQuery(id+"F10.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F10.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F10.wireOp",EDGE,"E19")}),1.0]])]});
            var Q4;
            Q4=makeQuery(id+"F10.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F10.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F10.wireOp",EDGE,"E20")}),1.0]])]});
            extrude(context, id + "F11", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4]), "operationType" : NewBodyOperationType.ADD, "depth" : 76.2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F12", { "sketchPlane" : qUnion([Q0])});
            skText(sketch, "E21", { "text": "Ring Toss", "fontName": "OpenSans-Regular.ttf"});
            const initialGuessF12  = {"E21": [-0.889, 0.80474, 1, 0, 0.1259]};
            skSetInitialGuess(sketch, initialGuessF12);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F12", true);
            extrude(context, id + "F13", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 6.35 * mm});
        }
    });