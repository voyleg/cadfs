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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 7.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 12 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            fillet(context, id + "F2", {"entities" : qUnion([Q0]), "radius" : 4 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            shell(context, id + "F3", {"entities" : qUnion([Q0]), "thickness" : 1 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1", {"start": v(9.78, 10.02) * mm, "end": v(2.59, 7.58) * mm});
            skLineSegment(sketch, "E2", {"start": v(1.9, 6.63) * mm, "end": v(1.9, 2.33) * mm});
            skLineSegment(sketch, "E3", {"start": v(2.83, 1.33) * mm, "end": v(10.31, 0.75) * mm});
            skLineSegment(sketch, "E4", {"start": v(10.31, 0.75) * mm, "end": v(9.78, 10.02) * mm});
            skPoint(sketch, "E5.visualSharp", {"position": v(1.9, 7.35) * mm});
            skArc(sketch, "E5.filletArc", {"start": v(2.59, 7.58) * mm, "mid": v(2.1, 7.22) * mm, "end": v(1.9, 6.63) * mm});
            skPoint(sketch, "E6.visualSharp", {"position": v(1.9, 1.4) * mm});
            skArc(sketch, "E6.filletArc", {"start": v(1.9, 2.33) * mm, "mid": v(2.18, 1.65) * mm, "end": v(2.83, 1.33) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E1")}),1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.SYMMETRIC, "oppositeDirection" : true, "depth" : 25 * mm, "offsetDistance" : 25 * mm});
        }
    });