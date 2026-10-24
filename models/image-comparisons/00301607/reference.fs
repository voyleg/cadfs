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
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(-300, 170) * mm});
            skLineSegment(sketch, "E1", {"start": v(-300, 170) * mm, "end": v(-300, 520) * mm});
            skLineSegment(sketch, "E2", {"start": v(-300, 520) * mm, "end": v(300, 520) * mm});
            skLineSegment(sketch, "E3", {"start": v(300, 520) * mm, "end": v(300, 170) * mm});
            skLineSegment(sketch, "E4", {"start": v(300, 170) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            cPlane(context, id + "F1", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 2000 * mm, "oppositeDirection" : true, "width" : 150 * mm, "height" : 150 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5", {"start": v(300, 170) * mm, "end": v(300, 520) * mm});
            skLineSegment(sketch, "E6", {"start": v(300, 520) * mm, "end": v(-300, 520) * mm});
            skLineSegment(sketch, "E7", {"start": v(-300, 520) * mm, "end": v(-300, 170) * mm});
            skLineSegment(sketch, "E8", {"start": v(300, 170) * mm, "end": v(0, 120) * mm});
            skLineSegment(sketch, "E9", {"start": v(0, 120) * mm, "end": v(-300, 170) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E5")}),1.0]])]});
            loft(context, id + "F3", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }]});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opLoft","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F2.wireOp",EDGE,"E5"),sQuery(id+"F2.wireOp",EDGE,"E6"),sQuery(id+"F2.wireOp",EDGE,"E7")])]});
            shell(context, id + "F4", {"entities" : qUnion([Q0]), "thickness" : 2 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E10", {"center": v(0, 30) * mm, "radius": 25 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F5", true);
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opLoft","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F2.wireOp",EDGE,"E5"),sQuery(id+"F2.wireOp",EDGE,"E6"),sQuery(id+"F2.wireOp",EDGE,"E7")])]});
            var sketch = newSketch(context, id + "F7", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E11.bottom", {"start": v(338, -38) * mm, "end": v(-338, -38) * mm});
            skLineSegment(sketch, "E11.top", {"start": v(338, 2038) * mm, "end": v(-338, 2038) * mm});
            skLineSegment(sketch, "E11.left", {"start": v(338, -38) * mm, "end": v(338, 2038) * mm});
            skLineSegment(sketch, "E11.right", {"start": v(-338, -38) * mm, "end": v(-338, 2038) * mm});
            skLineSegment(sketch, "E12.bottom", {"start": v(-298, 1998) * mm, "end": v(298, 1998) * mm});
            skLineSegment(sketch, "E12.top", {"start": v(-298, 2) * mm, "end": v(298, 2) * mm});
            skLineSegment(sketch, "E12.left", {"start": v(-298, 1998) * mm, "end": v(-298, 2) * mm});
            skLineSegment(sketch, "E12.right", {"start": v(298, 1998) * mm, "end": v(298, 2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F7", true);
            extrude(context, id + "F8", {"entities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F8.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E11.bottom"),sQuery(id+"F7.wireOp",EDGE,"E11.top"),sQuery(id+"F7.wireOp",EDGE,"E11.left"),sQuery(id+"F7.wireOp",EDGE,"E11.right"),sQuery(id+"F7.wireOp",EDGE,"E12.bottom"),sQuery(id+"F7.wireOp",EDGE,"E12.top"),sQuery(id+"F7.wireOp",EDGE,"E12.left"),sQuery(id+"F7.wireOp",EDGE,"E12.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F9", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E13.bottom", {"start": v(-338, 38) * mm, "end": v(338, 38) * mm});
            skLineSegment(sketch, "E13.top", {"start": v(-338, -2038) * mm, "end": v(338, -2038) * mm});
            skLineSegment(sketch, "E13.left", {"start": v(-338, 38) * mm, "end": v(-338, -2038) * mm});
            skLineSegment(sketch, "E13.right", {"start": v(338, 38) * mm, "end": v(338, -2038) * mm});
            skLineSegment(sketch, "E14.bottom", {"start": v(336, -2036) * mm, "end": v(-336, -2036) * mm});
            skLineSegment(sketch, "E14.top", {"start": v(336, 36) * mm, "end": v(-336, 36) * mm});
            skLineSegment(sketch, "E14.left", {"start": v(336, -2036) * mm, "end": v(336, 36) * mm});
            skLineSegment(sketch, "E14.right", {"start": v(-336, -2036) * mm, "end": v(-336, 36) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F9", true);
            extrude(context, id + "F10", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 30 * mm});
        }
    });