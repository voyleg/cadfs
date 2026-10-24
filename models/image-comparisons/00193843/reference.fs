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
            skLineSegment(sketch, "E0", {"start": v(0, 4.85) * mm, "end": v(0, -5.36) * mm, "construction": true});
            skCircle(sketch, "E1.cCircle", {"center": v(0, 0) * mm, "radius": 4.98 * mm, "construction": true});
            skLineSegment(sketch, "E1.0", {"start": v(0, 5.75) * mm, "end": v(4.98, 2.88) * mm});
            skLineSegment(sketch, "E1.1", {"start": v(4.98, 2.88) * mm, "end": v(4.98, -2.87) * mm});
            skLineSegment(sketch, "E1.2", {"start": v(4.98, -2.87) * mm, "end": v(0, -5.75) * mm});
            skLineSegment(sketch, "E1.3", {"start": v(0, -5.75) * mm, "end": v(-4.98, -2.87) * mm});
            skLineSegment(sketch, "E1.4", {"start": v(-4.98, -2.88) * mm, "end": v(-4.98, 2.88) * mm});
            skLineSegment(sketch, "E1.5", {"start": v(-4.98, 2.88) * mm, "end": v(0, 5.75) * mm});
            skPoint(sketch, "E1.0.midPoint", {"position": v(2.49, 4.31) * mm});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 3 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1.0")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 5 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E3", {"start": v(0, 4.78) * mm, "end": v(0, -4.6) * mm, "construction": true});
            skArc(sketch, "E4", {"start": v(-5, 5) * mm, "mid": v(-5.45, 4.86) * mm, "end": v(-5.75, 4.5) * mm});
            skLineSegment(sketch, "E5", {"start": v(-5.75, 4.5) * mm, "end": v(-5.75, 5) * mm});
            skLineSegment(sketch, "E6", {"start": v(-5, 5) * mm, "end": v(-5.75, 5) * mm});
            skLineSegment(sketch, "E7", {"start": v(-7.45, 2.5) * mm, "end": v(8.43, 2.5) * mm, "construction": true});
            skLineSegment(sketch, "E8.MirrorCS", {"start": v(-5, 0) * mm, "end": v(-5.75, 0) * mm});
            skLineSegment(sketch, "E9.MirrorCS", {"start": v(-5.75, 0.5) * mm, "end": v(-5.75, 0) * mm});
            skArc(sketch, "E10.MirrorCS", {"start": v(-5, 0) * mm, "mid": v(-5.45, 0.14) * mm, "end": v(-5.75, 0.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            var Q1;
            Q1=sQuery(id+"F2.wireOp",EDGE,"E3");
            revolve(context, id + "F3", {"operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL, "oppositeDirection" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])]});
            fillet(context, id + "F4", {"entities" : qUnion([Q0]), "radius" : .5 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });