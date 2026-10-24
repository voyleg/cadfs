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
            skLineSegment(sketch, "E0.top", {"start": v(76.2, 228.6) * mm, "end": v(152.4, 228.6) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(0, 0) * mm, "end": v(0, 152.4) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(228.6, 0) * mm, "end": v(228.6, 152.4) * mm});
            skPoint(sketch, "E1.visualSharp", {"position": v(0, 228.6) * mm});
            skArc(sketch, "E1.filletArc", {"start": v(76.2, 228.6) * mm, "mid": v(22.318463273585053, 206.28153672641494) * mm, "end": v(0, 152.4) * mm});
            skPoint(sketch, "E2.visualSharp", {"position": v(228.6, 228.6) * mm});
            skArc(sketch, "E2.filletArc", {"start": v(228.6, 152.4) * mm, "mid": v(206.28153672641494, 206.28153672641497) * mm, "end": v(152.4, 228.6) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E3", {"center": v(0, 0) * mm, "radius": 12.7 * mm});
            skCircle(sketch, "E4.0", {"center": v(0, 0) * mm, "radius": 11.2 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E3")}),1.0]])]});
            var Q1;
            Q1 = qConstructionFilter(qBodyType(qCreatedBy(id + "F0" ,EDGE), BodyType.WIRE), ConstructionObject.NO);
            sweep(context, id + "F2", {"profiles" : qUnion([Q0]), "path" : qUnion([Q1])});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            cPlane(context, id + "F3", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "oppositeDirection" : true, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F3.planeOp",FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E5", {"center": v(12.7, 0) * mm, "radius": 3.175 * mm});
            skCircle(sketch, "E6", {"center": v(88.9, 0) * mm, "radius": 3.175 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "depth" : 254 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E7", {"center": v(0, 152.4) * mm, "radius": 1.5875 * mm});
            skCircle(sketch, "E8", {"center": v(0, 76.2) * mm, "radius": 1.5875 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F6", true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.SYMMETRIC, "oppositeDirection" : true, "depth" : 25.4 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            cPlane(context, id + "F8", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 228.6 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var Q1;
            Q1=qCreatedBy(id+"F8.planeOp",FACE);
            cPlane(context, id + "F9", {"entities" : qUnion([Q0, Q1]), "cplaneType" : CPlaneType.MID_PLANE, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
    });