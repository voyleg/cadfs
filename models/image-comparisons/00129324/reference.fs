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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 50 * mm});
            skCircle(sketch, "E1", {"center": v(0, 37.5) * mm, "radius": 5 * mm});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 37.5 * mm, "construction": true});
            skCircle(sketch, "E3.1.0", {"center": v(-32.48, 18.75) * mm, "radius": 5 * mm});
            skCircle(sketch, "E3.2.0", {"center": v(-32.48, -18.75) * mm, "radius": 5 * mm});
            skCircle(sketch, "E3.3.0", {"center": v(0, -37.5) * mm, "radius": 5 * mm});
            skCircle(sketch, "E3.4.0", {"center": v(32.48, -18.75) * mm, "radius": 5 * mm});
            skCircle(sketch, "E3.5.0", {"center": v(32.48, 18.75) * mm, "radius": 5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 10 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            chamfer(context, id + "F2", {"entities" : qUnion([Q0, Q1]), "width" : 1 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E3.1.0"),sQuery(id+"F0.wireOp",EDGE,"E3.2.0"),sQuery(id+"F0.wireOp",EDGE,"E3.3.0"),sQuery(id+"F0.wireOp",EDGE,"E3.4.0"),sQuery(id+"F0.wireOp",EDGE,"E3.5.0")])],"isStart":false});
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E4", {"center": v(0, 0) * mm, "radius": 25 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F3", true);
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F3.wireOp",EDGE,"E4")])],"isStart":false});
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E5", {"center": v(0, 0) * mm, "radius": 16 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F5", true);
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F6.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E5")])],"isStart":true})});
            var Q1;
            Q1=makeQuery(id+"F4.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F3.wireOp",EDGE,"E4")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F6.boolean.opBoolean","INTERSECT",EDGE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E3.1.0"),sQuery(id+"F0.wireOp",EDGE,"E3.2.0"),sQuery(id+"F0.wireOp",EDGE,"E3.3.0"),sQuery(id+"F0.wireOp",EDGE,"E3.4.0"),sQuery(id+"F0.wireOp",EDGE,"E3.5.0")])],"isStart":true}),makeQuery(id+"F6.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E5")])]})]});
            chamfer(context, id + "F7", {"entities" : qUnion([Q0, Q1, Q2]), "width" : 1 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            cPlane(context, id + "F8", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25 * mm, "width" : 150 * mm, "height" : 150 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F8.planeOp",FACE);
            var sketch = newSketch(context, id + "F9", { "sketchPlane" : qUnion([Q0])});
            skPoint(sketch, "E6", {"position": v(0, -22.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F9.wireOp",VERTEX,"E6");
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E3.1.0"),sQuery(id+"F0.wireOp",EDGE,"E3.2.0"),sQuery(id+"F0.wireOp",EDGE,"E3.3.0"),sQuery(id+"F0.wireOp",EDGE,"E3.4.0"),sQuery(id+"F0.wireOp",EDGE,"E3.5.0")])]});
            hole(context, id + "F10", {"style" : HoleStyle.SIMPLE, "endStyle" : HoleEndStyle.BLIND, "standardTappedOrClearance" : lookupTablePath({ "standard" : "ISO", "engagement" : "75%", "pitch" : "0.9 mm", "size" : "M5", "type" : "Tapped" }), "standardBlindInLast" : lookupTablePath({ "standard" : "ISO", "engagement" : "75%", "pitch" : "0.9 mm", "size" : "M5", "type" : "Tapped" }), "holeDiameter" : 4.1 * mm, "holeDepth" : 15 * mm, "startFromSketch" : true, "locations" : qUnion([Q0]), "scope" : qUnion([Q1])});
        }
    });