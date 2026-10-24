FeatureScript 2066;
import(path : "onshape/std/geometry.fs", version : "2066.0");
import(path : "onshape/std/common.fs", version : "2066.0");
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
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(0, 21.5) * mm, "end": v(0, 26) * mm});
            skLineSegment(sketch, "E1", {"start": v(-1.1473460385830712, 28) * mm, "end": v(-1.5, 26) * mm});
            skLineSegment(sketch, "E2", {"start": v(-1.5, 26) * mm, "end": v(-6, 25.76416499322632) * mm});
            skLineSegment(sketch, "E3", {"start": v(-6, 25.76416499322632) * mm, "end": v(-6, 21.5) * mm});
            skLineSegment(sketch, "E4", {"start": v(-6, 21.5) * mm, "end": v(0, 21.5) * mm, "construction": true});
            skLineSegment(sketch, "E5", {"start": v(-1.5, 26) * mm, "end": v(0, 26) * mm, "construction": true});
            skLineSegment(sketch, "E6", {"start": v(0, 26) * mm, "end": v(-0.3526539614169304, 28) * mm});
            skLineSegment(sketch, "E7", {"start": v(-0.3526539614169299, 28) * mm, "end": v(-1.1473460385830712, 28) * mm});
            skLineSegment(sketch, "E8", {"start": v(0, 0) * mm, "end": v(28.684032563826648, 0) * mm, "construction": true});
            skLineSegment(sketch, "E9", {"start": v(-6, 21.5) * mm, "end": v(-7.626750040799379, 21.5) * mm});
            skLineSegment(sketch, "E10", {"start": v(-7.626750040799379, 21.5) * mm, "end": v(-7.626750040799379, 0) * mm});
            skLineSegment(sketch, "E11", {"start": v(-7.626750040799379, 0) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E12", {"start": v(0, 0) * mm, "end": v(0, 21.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E8");
            revolve(context, id + "F1", {"surfaceOperationType" : NewSurfaceOperationType.NEW, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E10")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E13.0", {"center": v(0, 0) * mm, "radius": 21.5 * mm});
            skArc(sketch, "E14", {"start": v(5.6204981985585585, -2.1) * mm, "mid": v(0, 6) * mm, "end": v(-5.620498198558562, -2.1) * mm});
            skArc(sketch, "E15", {"start": v(-2.3418742493994, -10.875) * mm, "mid": v(0, -12.5) * mm, "end": v(2.3418742493993987, -10.875) * mm});
            skLineSegment(sketch, "E16", {"start": v(-5.620498198558559, -2.1) * mm, "end": v(-2.3418742493994005, -10.875) * mm});
            skLineSegment(sketch, "E17", {"start": v(5.62049819855856, -2.1) * mm, "end": v(2.341874249399398, -10.875) * mm});
            skCircle(sketch, "E18", {"center": v(0, 0) * mm, "radius": 2.375 * mm});
            skCircle(sketch, "E19", {"center": v(0, -10) * mm, "radius": 1.5875 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E13.0")}),1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skEllipse(sketch, "E20", {"center": v(-2.75, 0) * mm, "majorRadius": 2.5 * mm, "minorRadius": 1.25 * mm, "majorAxis": v(1, 0)});
            skLineSegment(sketch, "E21.bottom", {"start": v(-0.25, 1.25) * mm, "end": v(-5.25, 1.25) * mm, "construction": true});
            skLineSegment(sketch, "E21.top", {"start": v(-0.25, -1.25) * mm, "end": v(-5.25, -1.25) * mm, "construction": true});
            skLineSegment(sketch, "E21.left", {"start": v(-0.25, 1.25) * mm, "end": v(-0.25, -1.25) * mm, "construction": true});
            skLineSegment(sketch, "E21.right", {"start": v(-5.25, 1.25) * mm, "end": v(-5.25, -1.25) * mm, "construction": true});
            skPoint(sketch, "E21.cornerSnap0", {"position": v(-2.75, 1.25) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            var Q1;
            Q1=makeQuery(id+"F3.boolean.opBoolean","COPY",FACE,{"derivedFrom":makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E13.0")])]})});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "endBound" : BoundingType.UP_TO_SURFACE, "depth" : 25 * mm, "endBoundEntityFace" : qUnion([Q1]), "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E20")])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E8");
            circularPattern(context, id + "F6", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "angle" : 360 * degree, "instanceCount" : 12, "equalSpace" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E10")])]});
            var sketch = newSketch(context, id + "F7", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E22", {"center": v(0, 0) * mm, "radius": 2.375 * mm});
            skCircle(sketch, "E23", {"center": v(0, -10) * mm, "radius": 1.5875 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F7.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F7.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F7.wireOp",EDGE,"E22")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F7.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F7.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F7.wireOp",EDGE,"E23")}),1.0]])]});
            extrude(context, id + "F8", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm, "offsetDistance" : 25 * mm});
        }
    });