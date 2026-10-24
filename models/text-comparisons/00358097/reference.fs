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
            skLineSegment(sketch, "E0.rect.bottom", {"start": v(10, 14) * mm, "end": v(-10, 14) * mm});
            skLineSegment(sketch, "E0.rect.top", {"start": v(10, -14) * mm, "end": v(-10, -14) * mm});
            skLineSegment(sketch, "E0.rect.left", {"start": v(10, 14) * mm, "end": v(10, -14) * mm});
            skLineSegment(sketch, "E0.rect.right", {"start": v(-10, 14) * mm, "end": v(-10, -14) * mm});
            skPoint(sketch, "E0.rect.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.rect.bottom")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3.6 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.rect.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.rect.top"),sQuery(id+"F0.wireOp",EDGE,"E0.rect.left"),sQuery(id+"F0.wireOp",EDGE,"E0.rect.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1", {"start": v(6.7, 10.4) * mm, "end": v(-6.7, 10.4) * mm});
            skLineSegment(sketch, "E2", {"start": v(-6.7, 10.4) * mm, "end": v(-6.7, -14) * mm});
            skLineSegment(sketch, "E3", {"start": v(6.69, 10.4) * mm, "end": v(6.69, -14) * mm});
            skLineSegment(sketch, "E4", {"start": v(6.69, -14) * mm, "end": v(10, -14) * mm});
            skLineSegment(sketch, "E5", {"start": v(10, -14) * mm, "end": v(10, 14) * mm});
            skLineSegment(sketch, "E6", {"start": v(10, 14) * mm, "end": v(-10, 14) * mm});
            skLineSegment(sketch, "E7", {"start": v(-10, 14) * mm, "end": v(-10, -14) * mm});
            skLineSegment(sketch, "E8", {"start": v(-10, -14) * mm, "end": v(-6.7, -14) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 28 * mm - 3.6 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.rect.left")])]}),makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E5")])]})]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E9", {"start": v(-14, 0) * mm, "end": v(-14, 6) * mm});
            skLineSegment(sketch, "E10", {"start": v(-14, 6) * mm, "end": v(-8, 6) * mm});
            skLineSegment(sketch, "E11", {"start": v(-8, 6) * mm, "end": v(8, 22) * mm});
            skLineSegment(sketch, "E12", {"start": v(8, 22) * mm, "end": v(8, 28) * mm});
            skLineSegment(sketch, "E13", {"start": v(8, 28) * mm, "end": v(14, 28) * mm});
            skLineSegment(sketch, "E14", {"start": v(14, 28) * mm, "end": v(14, 0) * mm});
            skLineSegment(sketch, "E15", {"start": v(14, 0) * mm, "end": v(-14, 0) * mm});
            skLineSegment(sketch, "E16", {"start": v(-14, 6) * mm, "end": v(-14, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F4",true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.INTERSECT, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.rect.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.rect.top"),sQuery(id+"F0.wireOp",EDGE,"E0.rect.left"),sQuery(id+"F0.wireOp",EDGE,"E0.rect.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E17.rect.bottom", {"start": v(-3.3, 2) * mm, "end": v(3.3, 2) * mm});
            skLineSegment(sketch, "E17.rect.top", {"start": v(-3.3, -2) * mm, "end": v(3.3, -2) * mm});
            skLineSegment(sketch, "E17.rect.left", {"start": v(-3.3, 2) * mm, "end": v(-3.3, -2) * mm});
            skLineSegment(sketch, "E17.rect.right", {"start": v(3.3, 2) * mm, "end": v(3.3, -2) * mm});
            skPoint(sketch, "E17.rect.middle", {"position": v(0, 0) * mm});
            skArc(sketch, "E18", {"start": v(-3.3, -2) * mm, "mid": v(0, -5.3) * mm, "end": v(3.3, -2) * mm});
            skArc(sketch, "E19", {"start": v(3.3, 2) * mm, "mid": v(0, 5.3) * mm, "end": v(-3.3, 2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F6",true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E1")])]});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E20.rect.bottom", {"start": v(3.3, 13.93) * mm, "end": v(-3.3, 13.93) * mm});
            skLineSegment(sketch, "E20.rect.top", {"start": v(3.3, 17.93) * mm, "end": v(-3.3, 17.93) * mm});
            skLineSegment(sketch, "E20.rect.left", {"start": v(3.3, 13.93) * mm, "end": v(3.3, 17.93) * mm});
            skLineSegment(sketch, "E20.rect.right", {"start": v(-3.3, 13.93) * mm, "end": v(-3.3, 17.93) * mm});
            skPoint(sketch, "E20.rect.middle", {"position": v(0, 15.93) * mm});
            skArc(sketch, "E21", {"start": v(-3.3, 13.93) * mm, "mid": v(0, 10.63) * mm, "end": v(3.3, 13.93) * mm});
            skArc(sketch, "E22", {"start": v(3.3, 17.93) * mm, "mid": v(0, 21.23) * mm, "end": v(-3.3, 17.93) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F8",true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25 * mm});
        }
    });