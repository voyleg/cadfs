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
            skLineSegment(sketch, "E0.bottom", {"start": v(25.4, -19.05) * mm, "end": v(-25.4, -19.05) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(25.4, 19.05) * mm, "end": v(-25.4, 19.05) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(25.4, -19.05) * mm, "end": v(25.4, 19.05) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-25.4, -19.05) * mm, "end": v(-25.4, 19.05) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skLineSegment(sketch, "E1.0", {"start": v(22.23, 15.88) * mm, "end": v(-22.23, 15.88) * mm});
            skLineSegment(sketch, "E1.1", {"start": v(22.23, -15.87) * mm, "end": v(22.23, 15.88) * mm});
            skLineSegment(sketch, "E1.2", {"start": v(22.23, -15.87) * mm, "end": v(-22.22, -15.87) * mm});
            skLineSegment(sketch, "E1.3", {"start": v(-22.22, -15.87) * mm, "end": v(-22.23, 15.88) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0.top");
            var Q2;
            Q2=sQuery(id+"F0.wireOp",EDGE,"E0.left");
            var Q3;
            Q3=sQuery(id+"F0.wireOp",EDGE,"E0.right");
            var Q4;
            Q4=sQuery(id+"F0.wireOp",EDGE,"E0.bottom");
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "surfaceEntities" : qUnion([Q1, Q2, Q3, Q4]), "depth" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E2.bottom", {"start": v(-19.05, -152.4) * mm, "end": v(19.05, -152.4) * mm});
            skLineSegment(sketch, "E2.top", {"start": v(-12.7, -101.6) * mm, "end": v(12.7, -101.6) * mm});
            skLineSegment(sketch, "E2.left", {"start": v(-19.05, -152.4) * mm, "end": v(-19.05, -107.95) * mm});
            skLineSegment(sketch, "E2.right", {"start": v(19.05, -152.4) * mm, "end": v(19.05, -107.95) * mm});
            skPoint(sketch, "E2.middle", {"position": v(0, -127) * mm});
            skPoint(sketch, "E2.middle.positionSnap0", {"position": v(0, -152.4) * mm});
            skPoint(sketch, "E2.centerSnap0", {"position": v(0, -152.4) * mm});
            skPoint(sketch, "E3.visualSharp", {"position": v(-19.05, -101.6) * mm});
            skArc(sketch, "E3.filletArc", {"start": v(-12.7, -101.6) * mm, "mid": v(-17.2, -103.46) * mm, "end": v(-19.05, -107.95) * mm});
            skPoint(sketch, "E4.visualSharp", {"position": v(19.05, -101.6) * mm});
            skArc(sketch, "E4.filletArc", {"start": v(19.05, -107.95) * mm, "mid": v(17.2, -103.46) * mm, "end": v(12.7, -101.6) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E5", {"center": v(-127, -3.17) * mm, "radius": 12.86 * mm});
            skCircle(sketch, "E6", {"center": v(-69.43, 0) * mm, "radius": 12.86 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E5")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E6")}),1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E7.bottom", {"start": v(0, -19.05) * mm, "end": v(-38.1, -19.05) * mm});
            skLineSegment(sketch, "E7.top", {"start": v(0, 12.7) * mm, "end": v(-31.75, 12.7) * mm});
            skLineSegment(sketch, "E7.left", {"start": v(0, -19.05) * mm, "end": v(0, 12.7) * mm});
            skLineSegment(sketch, "E7.right", {"start": v(-38.1, -19.05) * mm, "end": v(-38.1, 6.35) * mm});
            skPoint(sketch, "E8.visualSharp", {"position": v(-38.1, 12.7) * mm});
            skArc(sketch, "E8.filletArc", {"start": v(-31.75, 12.7) * mm, "mid": v(-36.24, 10.84) * mm, "end": v(-38.1, 6.35) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F6", true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25.4 * mm});
        }
    });