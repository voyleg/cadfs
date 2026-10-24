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
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0.bottom", {"start": v(-127, 25.4) * mm, "end": v(127, 25.4) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-127, -25.4) * mm, "end": v(127, -25.4) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-127, 25.4) * mm, "end": v(-127, -25.4) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(127, 25.4) * mm, "end": v(127, -25.4) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 50.8 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skPoint(sketch, "E1.0.internal.orphan", {"position": v(0, 127) * mm});
            skPoint(sketch, "E1.7.internal.orphan", {"position": v(0, -127) * mm});
            skFitSpline(sketch, "E2", {"points": [v(0, 127) * mm, v(-7.65, 123.35) * mm, v(-15.53, 97.1) * mm, v(-11.15, 53.36) * mm, v(-4.16, 21) * mm, v(-5.03, -25.37) * mm, v(-17.71, -57.74) * mm, v(-20.34, -96.66) * mm, v(-12.9, -121.16) * mm, v(0, -127) * mm], "startDerivative": vector(-133.08, -29.89) * mm, "endDerivative": vector(183.81, -43.16) * mm});
            skFitSpline(sketch, "E3.MirrorCS", {"points": [v(0, 127) * mm, v(7.65, 123.35) * mm, v(15.53, 97.1) * mm, v(11.15, 53.36) * mm, v(4.16, 21) * mm, v(5.03, -25.37) * mm, v(17.71, -57.74) * mm, v(20.34, -96.66) * mm, v(12.9, -121.16) * mm, v(0, -127) * mm], "startDerivative": vector(133.08, -29.89) * mm, "endDerivative": vector(-183.81, -43.16) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E2")}),1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.INTERSECT, "endBound" : BoundingType.SYMMETRIC, "depth" : 127 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skFitSpline(sketch, "E4", {"points": [v(124.57, 0) * mm, v(121.09, -6.55) * mm, v(10.47, -9.53) * mm, v(-18.36, -5.3) * mm, v(-62.1, -14.75) * mm, v(-111.57, -15.5) * mm, v(-125.25, -2.57) * mm, v(-125.5, 5.88) * mm], "startDerivative": vector(1.7, -102.64) * mm, "endDerivative": vector(15.92, 110) * mm});
            skFitSpline(sketch, "E5", {"points": [v(124.57, 0) * mm, v(124.57, 2.4) * mm, v(45.02, 3.9) * mm, v(-18.11, 2.4) * mm, v(-125.5, 5.88) * mm], "startDerivative": vector(22.55, 47.6) * mm, "endDerivative": vector(-329.99, 13.65) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.INTERSECT, "endBound" : BoundingType.SYMMETRIC, "depth" : 50.8 * mm});
        }
    });