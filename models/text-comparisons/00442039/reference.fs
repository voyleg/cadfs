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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 25.4 * mm});
            skCircle(sketch, "E1", {"center": v(0, -11.43) * mm, "radius": 11.43 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 5.08 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1")}),1.0]])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2.54 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":false});
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2.cCircle", {"center": v(0, 11.5) * mm, "radius": 7.62 * mm, "construction": true});
            skLineSegment(sketch, "E2.0", {"start": v(3.67, 3.87) * mm, "end": v(-3.67, 3.87) * mm});
            skLineSegment(sketch, "E2.1", {"start": v(-3.67, 3.87) * mm, "end": v(-8.25, 9.61) * mm});
            skLineSegment(sketch, "E2.2", {"start": v(-8.25, 9.61) * mm, "end": v(-6.61, 16.77) * mm});
            skLineSegment(sketch, "E2.3", {"start": v(-6.61, 16.77) * mm, "end": v(0, 19.95) * mm});
            skLineSegment(sketch, "E2.4", {"start": v(0, 19.95) * mm, "end": v(6.61, 16.77) * mm});
            skLineSegment(sketch, "E2.5", {"start": v(6.61, 16.77) * mm, "end": v(8.25, 9.61) * mm});
            skLineSegment(sketch, "E2.6", {"start": v(8.25, 9.61) * mm, "end": v(3.67, 3.87) * mm});
            skPoint(sketch, "E2.0.midPoint", {"position": v(0, 3.87) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F3.wireOp",EDGE,"E2.0")}),-1.0]])]});
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 25.4 * mm, "hasDraft" : true, "draftAngle" : 3 * degree, "draftPullDirection" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F3.wireOp",EDGE,"E2.0"),sQuery(id+"F3.wireOp",EDGE,"E2.1"),sQuery(id+"F3.wireOp",EDGE,"E2.2"),sQuery(id+"F3.wireOp",EDGE,"E2.3"),sQuery(id+"F3.wireOp",EDGE,"E2.4"),sQuery(id+"F3.wireOp",EDGE,"E2.5"),sQuery(id+"F3.wireOp",EDGE,"E2.6")])],"isStart":false});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 5.08 * mm, "hasDraft" : true, "draftAngle" : 30 * degree});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F3.wireOp",EDGE,"E2.0"),sQuery(id+"F3.wireOp",EDGE,"E2.1"),sQuery(id+"F3.wireOp",EDGE,"E2.2"),sQuery(id+"F3.wireOp",EDGE,"E2.3"),sQuery(id+"F3.wireOp",EDGE,"E2.4"),sQuery(id+"F3.wireOp",EDGE,"E2.5"),sQuery(id+"F3.wireOp",EDGE,"E2.6")])],"isStart":false});
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 25.4 * mm, "hasDraft" : true, "draftAngle" : 45 * degree, "draftPullDirection" : true});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F7", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E3", {"start": v(-3.67, 5.08) * mm, "end": v(0, 5.08) * mm});
            skLineSegment(sketch, "E4", {"start": v(-3.67, 5.08) * mm, "end": v(-3.54, 10.16) * mm});
            skLineSegment(sketch, "E5", {"start": v(-3.54, 10.16) * mm, "end": v(0, 10.16) * mm});
            skLineSegment(sketch, "E6", {"start": v(0, 10.16) * mm, "end": v(0, 5.08) * mm});
            skLineSegment(sketch, "E7.MirrorCS", {"start": v(3.54, 10.16) * mm, "end": v(0, 10.16) * mm});
            skLineSegment(sketch, "E8.MirrorCS", {"start": v(3.67, 5.08) * mm, "end": v(3.54, 10.16) * mm});
            skLineSegment(sketch, "E9.MirrorCS", {"start": v(3.67, 5.08) * mm, "end": v(0, 5.08) * mm});
            skPoint(sketch, "E10.oppositeSnap0", {"position": v(1.83, 5.08) * mm});
            skLineSegment(sketch, "E10.bottom", {"start": v(-1.83, 5.08) * mm, "end": v(1.83, 5.08) * mm});
            skLineSegment(sketch, "E10.top", {"start": v(-1.83, 8.9) * mm, "end": v(1.83, 8.9) * mm});
            skLineSegment(sketch, "E10.left", {"start": v(-1.83, 5.08) * mm, "end": v(-1.83, 8.9) * mm});
            skLineSegment(sketch, "E10.right", {"start": v(1.83, 5.08) * mm, "end": v(1.83, 8.9) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ3=sQuery(id+"F7.wireOp",EDGE,"E7.MirrorCS");Q0=makeQuery(id+"F7.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F7.imprint","IMPRINT",EDGE,{"derivedFrom":subQ3}),1.0]])]});}
            var Q1;
            {var subQ1=sQuery(id+"F7.wireOp",EDGE,"E4");Q1=makeQuery(id+"F7.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F7.imprint","IMPRINT",EDGE,{"derivedFrom":subQ1}),-1.0]])]});}
            extrude(context, id + "F8", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 5.08 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : 2.54 * mm});
        }
    });