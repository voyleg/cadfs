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
            skArc(sketch, "E0", {"start": v(0, 11) * mm, "mid": v(-11, 0) * mm, "end": v(0, -11) * mm});
            skLineSegment(sketch, "E1", {"start": v(0, 11) * mm, "end": v(94, 11) * mm});
            skLineSegment(sketch, "E2", {"start": v(0, -11) * mm, "end": v(19, -11) * mm});
            skArc(sketch, "E3", {"start": v(23.66, -14.2) * mm, "mid": v(43.65, -42.52) * mm, "end": v(74.64, -58.02) * mm});
            skArc(sketch, "E4", {"start": v(90.8, -62.53) * mm, "mid": v(83.16, -58.7) * mm, "end": v(74.64, -58.02) * mm});
            skPoint(sketch, "E5.visualSharp", {"position": v(22.52, -11) * mm});
            skArc(sketch, "E5.filletArc", {"start": v(23.66, -14.2) * mm, "mid": v(21.83, -11.88) * mm, "end": v(19, -11) * mm});
            skLineSegment(sketch, "E6.0", {"start": v(0, 9) * mm, "end": v(94, 9) * mm});
            skArc(sketch, "E6.1", {"start": v(0, 9) * mm, "mid": v(-9, 0) * mm, "end": v(0, -9) * mm});
            skArc(sketch, "E6.2", {"start": v(92.1, -61) * mm, "mid": v(83.9, -56.84) * mm, "end": v(74.75, -56) * mm});
            skArc(sketch, "E6.3", {"start": v(25.53, -13.48) * mm, "mid": v(44.83, -40.9) * mm, "end": v(74.75, -56) * mm});
            skArc(sketch, "E6.4", {"start": v(25.53, -13.48) * mm, "mid": v(22.96, -10.23) * mm, "end": v(19, -9) * mm});
            skLineSegment(sketch, "E6.5", {"start": v(0, -9) * mm, "end": v(19, -9) * mm});
            skLineSegment(sketch, "E7", {"start": v(92.1, -61) * mm, "end": v(90.8, -62.53) * mm});
            skLineSegment(sketch, "E8", {"start": v(94, 9) * mm, "end": v(94, 11) * mm});
            skLineSegment(sketch, "E9", {"start": v(95.6, -60.89) * mm, "end": v(104.54, -60.89) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 16 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E10.bottom", {"start": v(24, -16) * mm, "end": v(94, -16) * mm});
            skLineSegment(sketch, "E10.top", {"start": v(24, -19) * mm, "end": v(94, -19) * mm});
            skLineSegment(sketch, "E10.left", {"start": v(24, -16) * mm, "end": v(24, -19) * mm});
            skLineSegment(sketch, "E10.right", {"start": v(94, -16) * mm, "end": v(94, -19) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E10.top")])]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E11.bottom", {"start": v(94, 11) * mm, "end": v(44, 11) * mm});
            skLineSegment(sketch, "E11.top", {"start": v(94, -3) * mm, "end": v(44, -3) * mm});
            skLineSegment(sketch, "E11.left", {"start": v(94, 11) * mm, "end": v(94, -3) * mm});
            skLineSegment(sketch, "E11.right", {"start": v(44, 11) * mm, "end": v(44, -3) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E10.top")])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F5.boolean.opBoolean","MERGE",EDGE,{"derivedFrom":[makeQuery(id+"F3.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E10.top"),sQuery(id+"F2.wireOp",EDGE,"E10.right")])]}),makeQuery(id+"F5.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E11.left")])],"isStart":true})]});
            fillet(context, id + "F6", {"entities" : qUnion([Q0, Q1]), "radius" : 1 * mm, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4"),sQuery(id+"F0.wireOp",EDGE,"E5.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E6.0"),sQuery(id+"F0.wireOp",EDGE,"E6.1"),sQuery(id+"F0.wireOp",EDGE,"E6.2"),sQuery(id+"F0.wireOp",EDGE,"E6.3"),sQuery(id+"F0.wireOp",EDGE,"E6.4"),sQuery(id+"F0.wireOp",EDGE,"E6.5"),sQuery(id+"F0.wireOp",EDGE,"E7"),sQuery(id+"F0.wireOp",EDGE,"E8")])]});
            var Q1;
            Q1=qCreatedBy(makeId("Front.planeOp"),FACE);
            mirror(context, id + "F7", {"operationType" : NewBodyOperationType.ADD, "entities" : qUnion([Q0]), "mirrorPlane" : qUnion([Q1])});
        }
        {
            var Q0;
            {var subQ0=makeQuery(id+"F3.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])]}),makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E10.bottom"),sQuery(id+"F2.wireOp",EDGE,"E10.top"),sQuery(id+"F2.wireOp",EDGE,"E10.left"),sQuery(id+"F2.wireOp",EDGE,"E10.right")])],"isStart":true})]});Q0=makeQuery(id+"F7.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[subQ0,makeQuery(id+"F7.opPattern","COPY",FACE,{"derivedFrom":subQ0,"instanceName":"1"})]});}
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E12", {"start": v(34, 12) * mm, "mid": v(22, 0) * mm, "end": v(34, -12) * mm});
            skLineSegment(sketch, "E13", {"start": v(34, 12) * mm, "end": v(94, 12) * mm});
            skLineSegment(sketch, "E14", {"start": v(34, -12) * mm, "end": v(94, -12) * mm});
            skLineSegment(sketch, "E15", {"start": v(94, -12) * mm, "end": v(94, 12) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F8", true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 2 * mm});
        }
    });