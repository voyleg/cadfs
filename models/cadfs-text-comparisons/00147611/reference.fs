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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 26.28 * mm});
            skCircle(sketch, "E1", {"center": v(8.25, -4.76) * mm, "radius": 3.97 * mm, "construction": true});
            skCircle(sketch, "E2", {"center": v(0, 9.52) * mm, "radius": 1.73 * mm});
            skCircle(sketch, "E3", {"center": v(-8.25, -4.76) * mm, "radius": 1.73 * mm});
            skCircle(sketch, "E4", {"center": v(8.25, -4.76) * mm, "radius": 1.73 * mm});
            skCircle(sketch, "E5", {"center": v(0, 0) * mm, "radius": 5.56 * mm});
            skCircle(sketch, "E6.cCircle", {"center": v(0, 0) * mm, "radius": 4.76 * mm, "construction": true});
            skLineSegment(sketch, "E6.0", {"start": v(8.25, -4.76) * mm, "end": v(-8.25, -4.76) * mm, "construction": true});
            skLineSegment(sketch, "E6.1", {"start": v(-8.25, -4.76) * mm, "end": v(0, 9.53) * mm, "construction": true});
            skLineSegment(sketch, "E6.2", {"start": v(0, 9.53) * mm, "end": v(8.25, -4.76) * mm, "construction": true});
            skPoint(sketch, "E6.0.midPoint", {"position": v(0, -4.76) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3.25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E7", {"start": v(0, 0) * mm, "end": v(0, 26.28) * mm});
            skArc(sketch, "E8", {"start": v(1.06, 26.26) * mm, "mid": v(0, 26.28) * mm, "end": v(-1.06, 26.26) * mm});
            skLineSegment(sketch, "E9", {"start": v(-1.06, 26.26) * mm, "end": v(-0.28, 24.32) * mm});
            skLineSegment(sketch, "E10", {"start": v(1.06, 26.26) * mm, "end": v(0.28, 24.32) * mm});
            skArc(sketch, "E11", {"start": v(-0.28, 24.32) * mm, "mid": v(0, 24.13) * mm, "end": v(0.28, 24.32) * mm});
            skLineSegment(sketch, "E12", {"start": v(0, 0) * mm, "end": v(0.7, 26.27) * mm, "construction": true});
            skPoint(sketch, "E13", {"position": v(0.67, 25.3) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F2",true);
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.UP_TO_SURFACE, "oppositeDirection" : true, "endBoundEntityFace" : qUnion([Q1]), "depth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.boolean.opBoolean","COPY",FACE,{"derivedFrom":makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E10")])]})});
            var Q1;
            Q1=makeQuery(id+"F3.boolean.opBoolean","COPY",FACE,{"derivedFrom":makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E11")])]})});
            var Q2;
            Q2=makeQuery(id+"F3.boolean.opBoolean","COPY",FACE,{"derivedFrom":makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E9")])]})});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])]});
            circularPattern(context, id + "F4", {"patternType" : PatternType.FACE, "faces" : qUnion([Q0, Q1, Q2]), "axis" : qUnion([Q3]), "angle" : 6.8 * degree, "instanceCount" : 53});
        }
    });