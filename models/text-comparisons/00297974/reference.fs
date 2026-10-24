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
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(-76.2, 0) * mm});
            skLineSegment(sketch, "E1", {"start": v(-76.2, 0) * mm, "end": v(-76.2, 76.2) * mm});
            skLineSegment(sketch, "E2", {"start": v(-76.2, 76.2) * mm, "end": v(-50.8, 76.2) * mm});
            skLineSegment(sketch, "E3", {"start": v(-50.8, 76.2) * mm, "end": v(-50.8, 50.8) * mm});
            skLineSegment(sketch, "E4", {"start": v(-50.8, 50.8) * mm, "end": v(-25.4, 50.8) * mm});
            skLineSegment(sketch, "E5", {"start": v(-25.4, 50.8) * mm, "end": v(-25.4, 25.4) * mm});
            skLineSegment(sketch, "E6", {"start": v(-25.4, 25.4) * mm, "end": v(0, 25.4) * mm});
            skLineSegment(sketch, "E7", {"start": v(0, 25.4) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 76.2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E8.bottom", {"start": v(-76.2, 63.5) * mm, "end": v(0, 63.5) * mm});
            skLineSegment(sketch, "E8.top", {"start": v(-76.2, 50.8) * mm, "end": v(0, 50.8) * mm});
            skLineSegment(sketch, "E8.left", {"start": v(-76.2, 63.5) * mm, "end": v(-76.2, 50.8) * mm});
            skLineSegment(sketch, "E8.right", {"start": v(0, 63.5) * mm, "end": v(0, 50.8) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E8.bottom")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 12.7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5")])]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E9.bottom", {"start": v(-76.2, 38.1) * mm, "end": v(0, 38.1) * mm});
            skLineSegment(sketch, "E9.top", {"start": v(-76.2, 25.4) * mm, "end": v(0, 25.4) * mm});
            skLineSegment(sketch, "E9.left", {"start": v(-76.2, 38.1) * mm, "end": v(-76.2, 25.4) * mm});
            skLineSegment(sketch, "E9.right", {"start": v(0, 38.1) * mm, "end": v(0, 25.4) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E9.bottom")}),-1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 12.7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7")])]});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E10.bottom", {"start": v(-76.2, 12.7) * mm, "end": v(0, 12.7) * mm});
            skLineSegment(sketch, "E10.top", {"start": v(-76.2, 0) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E10.left", {"start": v(-76.2, 12.7) * mm, "end": v(-76.2, 0) * mm});
            skLineSegment(sketch, "E10.right", {"start": v(0, 12.7) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E10.bottom")}),-1.0]])]});
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 12.7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])]});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E11.bottom", {"start": v(-63.5, 0) * mm, "end": v(-76.2, 0) * mm});
            skLineSegment(sketch, "E11.top", {"start": v(-63.5, -76.2) * mm, "end": v(-76.2, -76.2) * mm});
            skLineSegment(sketch, "E11.left", {"start": v(-63.5, 0) * mm, "end": v(-63.5, -76.2) * mm});
            skLineSegment(sketch, "E11.right", {"start": v(-76.2, 0) * mm, "end": v(-76.2, -76.2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F8.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F8.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F8.wireOp",EDGE,"E11.bottom")}),-1.0]])]});
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 12.7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F7.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E10.bottom"),sQuery(id+"F6.wireOp",EDGE,"E10.top"),sQuery(id+"F6.wireOp",EDGE,"E10.left"),sQuery(id+"F6.wireOp",EDGE,"E10.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F10", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E12.bottom", {"start": v(-76.2, 12.7) * mm, "end": v(0, 12.7) * mm});
            skLineSegment(sketch, "E12.top", {"start": v(-76.2, 0) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E12.left", {"start": v(-76.2, 12.7) * mm, "end": v(-76.2, 0) * mm});
            skLineSegment(sketch, "E12.right", {"start": v(0, 12.7) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F10.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F10.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F10.wireOp",EDGE,"E12.bottom")}),-1.0]])]});
            extrude(context, id + "F11", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 101.6 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F11.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F7.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E10.bottom")])]}),makeQuery(id+"F11.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F10.wireOp",EDGE,"E12.bottom")])]})]});
            var sketch = newSketch(context, id + "F12", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E13", {"start": v(0, -76.2) * mm, "end": v(114.3, -59.11) * mm});
            skLineSegment(sketch, "E14", {"start": v(0, 0) * mm, "end": v(114.3, -17.09) * mm});
            skLineSegment(sketch, "E15", {"start": v(0, -67.39) * mm, "end": v(114.3, -50.22) * mm});
            skLineSegment(sketch, "E16", {"start": v(0, -10.74) * mm, "end": v(114.3, -27.82) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F12.wireOp",EDGE,"E13");Q0=makeQuery(id+"F12.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F12.imprint","IMPRINT",EDGE,{"derivedFrom":subQ0}),1.0]])]});}
            var Q1;
            {var subQ0=sQuery(id+"F12.wireOp",EDGE,"E14");Q1=makeQuery(id+"F12.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F12.imprint","IMPRINT",EDGE,{"derivedFrom":subQ0}),-1.0]])]});}
            extrude(context, id + "F13", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.ADD, "depth" : 12.7 * mm});
        }
        {
            var Q0;
            {var subQ1=sQuery(id+"F10.wireOp",EDGE,"E12.bottom");Q0=makeQuery(id+"F13.boolean.opBoolean","SPLIT",FACE,{"disambiguationData":[TD([makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E8.left")])]})])],"derivedFrom":makeQuery(id+"F11.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F7.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E10.bottom")])]}),makeQuery(id+"F11.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ1])]})]})});}
            extrude(context, id + "F14", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25.4 * mm});
        }
        {
            var Q0;
            {var subQ1=sQuery(id+"F10.wireOp",EDGE,"E12.bottom");Q0=makeQuery(id+"F13.boolean.opBoolean","SPLIT",FACE,{"disambiguationData":[TD([makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E8.right")])]})])],"derivedFrom":makeQuery(id+"F11.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F7.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E10.bottom")])]}),makeQuery(id+"F11.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ1])]})]})});}
            extrude(context, id + "F15", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25.4 * mm});
        }
    });