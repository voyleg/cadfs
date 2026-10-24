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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 2.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 6 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1", {"start": v(0, -2.5) * mm, "end": v(0, 2.5) * mm});
            skArc(sketch, "E2", {"start": v(0, 2.5) * mm, "mid": v(-2.5, 0) * mm, "end": v(0, -2.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F2",true);
            var Q1;
            Q1=sQuery(id+"F2.wireOp",EDGE,"E1");
            revolve(context, id + "F3", {"operationType" : NewBodyOperationType.ADD, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E3.0", {"start": v(-2.5, -1.66) * mm, "mid": v(3, 0) * mm, "end": v(-2.5, 1.66) * mm});
            skLineSegment(sketch, "E4", {"start": v(-2.5, -1.66) * mm, "end": v(-2.5, 1.66) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F4",true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : .7 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true}),makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E3.0"),sQuery(id+"F4.wireOp",EDGE,"E4")])],"isStart":true})]});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5.rect.bottom", {"start": v(0.95, -0.3) * mm, "end": v(1.55, -0.3) * mm});
            skLineSegment(sketch, "E5.rect.top", {"start": v(0.95, 0.3) * mm, "end": v(1.55, 0.3) * mm});
            skLineSegment(sketch, "E5.rect.left", {"start": v(0.95, -0.3) * mm, "end": v(0.95, 0.3) * mm});
            skLineSegment(sketch, "E5.rect.right", {"start": v(1.55, -0.3) * mm, "end": v(1.55, 0.3) * mm});
            skPoint(sketch, "E5.rect.middle", {"position": v(1.25, 0) * mm});
            skLineSegment(sketch, "E6.rect.bottom", {"start": v(-0.95, -0.3) * mm, "end": v(-1.55, -0.3) * mm});
            skLineSegment(sketch, "E6.rect.top", {"start": v(-0.95, 0.3) * mm, "end": v(-1.55, 0.3) * mm});
            skLineSegment(sketch, "E6.rect.left", {"start": v(-0.95, -0.3) * mm, "end": v(-0.95, 0.3) * mm});
            skLineSegment(sketch, "E6.rect.right", {"start": v(-1.55, -0.3) * mm, "end": v(-1.55, 0.3) * mm});
            skPoint(sketch, "E6.rect.middle", {"position": v(-1.25, 0) * mm});
            skLineSegment(sketch, "E7", {"start": v(1.55, -0.3) * mm, "end": v(0.95, 0.3) * mm, "construction": true});
            skLineSegment(sketch, "E8", {"start": v(1.55, 0.3) * mm, "end": v(0.95, -0.3) * mm, "construction": true});
            skLineSegment(sketch, "E9", {"start": v(-0.95, -0.3) * mm, "end": v(-1.55, 0.3) * mm, "construction": true});
            skLineSegment(sketch, "E10", {"start": v(-0.95, 0.3) * mm, "end": v(-1.55, -0.3) * mm, "construction": true});
            skLineSegment(sketch, "E11", {"start": v(1.25, 0) * mm, "end": v(-1.25, 0) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F6",true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 20 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F7.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E5.rect.bottom"),sQuery(id+"F6.wireOp",EDGE,"E5.rect.top"),sQuery(id+"F6.wireOp",EDGE,"E5.rect.left"),sQuery(id+"F6.wireOp",EDGE,"E5.rect.right")])],"isStart":false});
            extrude(context, id + "F8", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F9", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E12", {"center": v(7.44, 15.47) * mm, "radius": 4.08 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F9.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F9.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F9.wireOp",EDGE,"E12")}),1.0]])]});
            extrude(context, id + "F10", {"entities" : qUnion([Q0]), "depth" : 0.62 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F10.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F9.wireOp",EDGE,"E12")])]});
            deleteBodies(context, id + "F11", {"entities" : qUnion([Q0])});
        }
    });