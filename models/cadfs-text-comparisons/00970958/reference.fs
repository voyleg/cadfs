FeatureScript 1717;
import(path : "onshape/std/geometry.fs", version : "1717.0");
import(path : "onshape/std/common.fs", version : "1717.0");
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
            skLineSegment(sketch, "E0.bottom", {"start": v(10, 8.5) * mm, "end": v(2, 8.5) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(10, -8.5) * mm, "end": v(-10, -8.5) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(10, 8.5) * mm, "end": v(10, -8.5) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-10, 8.5) * mm, "end": v(-10, -8.5) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(-2, 12.5) * mm, "end": v(2, 12.5) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(-2, 8.5) * mm, "end": v(-2, 12.5) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(2, 8.5) * mm, "end": v(2, 12.5) * mm});
            skLineSegment(sketch, "E2.trimOffspring", {"start": v(-2, 8.5) * mm, "end": v(-10, 8.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),1.0]])]});
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")})}),1.0]])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "depth" : 2 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right"),sQuery(id+"F0.wireOp",EDGE,"E1.top"),sQuery(id+"F0.wireOp",EDGE,"E1.left"),sQuery(id+"F0.wireOp",EDGE,"E1.right"),sQuery(id+"F0.wireOp",EDGE,"E2.trimOffspring")])],"isStart":false});
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E3.bottom", {"start": v(-10, 8.5) * mm, "end": v(-2, 8.5) * mm});
            skLineSegment(sketch, "E3.top", {"start": v(-10, -3.5) * mm, "end": v(-2, -3.5) * mm});
            skLineSegment(sketch, "E3.left", {"start": v(-10, 8.5) * mm, "end": v(-10, -3.5) * mm});
            skLineSegment(sketch, "E3.right", {"start": v(-2, 8.5) * mm, "end": v(-2, -3.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F3.wireOp",EDGE,"E3.bottom")}),1.0]])]});
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.top")])]});
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E4", {"center": v(0, -1) * mm, "radius": 0.5 * mm});
            skPoint(sketch, "E4.centerSnap0", {"position": v(-2, -1) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5", {"start": v(0, 0.32) * mm, "end": v(0, 12.5) * mm, "construction": true});
            skLineSegment(sketch, "E6.0", {"start": v(-1, 0.32) * mm, "end": v(-1, 12.5) * mm, "construction": true});
            skFitSpline(sketch, "E7", {"points": [v(-1, 12.5) * mm, v(-1, 13.15) * mm, v(-0.63, 19.86) * mm, v(0.8, 67.5) * mm], "startDerivative": vector(-0.2, 11.54) * mm, "endDerivative": vector(3.52, 25.7) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F5.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F5.wireOp",EDGE,"E4")}),1.0]])]});
            var Q1;
            Q1=sQuery(id+"F6.wireOp",EDGE,"E7");
            sweep(context, id + "F7", {"operationType" : NewBodyOperationType.ADD, "profiles" : qUnion([Q0]), "path" : qUnion([Q1])});
        }
    });