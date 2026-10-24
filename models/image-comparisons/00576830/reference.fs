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
            skLineSegment(sketch, "E0", {"start": v(0, 22.58) * mm, "end": v(1.59, 22.58) * mm});
            skLineSegment(sketch, "E1", {"start": v(1.59, 22.58) * mm, "end": v(1.59, 0.35) * mm});
            skLineSegment(sketch, "E2", {"start": v(6.05, 37.92) * mm, "end": v(4.76, 37.92) * mm});
            skLineSegment(sketch, "E3", {"start": v(4.76, 37.92) * mm, "end": v(4.76, 28.4) * mm});
            skLineSegment(sketch, "E4", {"start": v(4.76, 28.4) * mm, "end": v(0, 28.4) * mm});
            skLineSegment(sketch, "E5", {"start": v(0, 28.4) * mm, "end": v(0, 22.58) * mm});
            skArc(sketch, "E6", {"start": v(18.62, 3.32) * mm, "mid": v(31.75, 8.13) * mm, "end": v(18.62, 12.95) * mm});
            skFitSpline(sketch, "E7", {"points": [v(2.3, 0.35) * mm, v(5.94, 4.24) * mm, v(9.37, 5.74) * mm, v(14.13, 5.74) * mm, v(18.62, 3.32) * mm], "startDerivative": vector(10.9, 18.53) * mm, "endDerivative": vector(13.62, -14.83) * mm});
            skFitSpline(sketch, "E8", {"points": [v(18.62, 12.95) * mm, v(14.16, 10.39) * mm, v(9.42, 12.56) * mm, v(6.05, 37.92) * mm], "startDerivative": vector(-16.77, -18.81) * mm, "endDerivative": vector(-4.23, 68.48) * mm});
            skLineSegment(sketch, "E9", {"start": v(1.59, 0.35) * mm, "end": v(2.3, 0.35) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            var Q1;
            Q1 = qSketchRegion(id + "F0", true);
            var Q2;
            Q2=sQuery(id+"F0.wireOp",EDGE,"E5");
            revolve(context, id + "F1", {"entities" : qUnion([Q0, Q1]), "axis" : qUnion([Q2]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E10", {"center": v(0, 0) * mm, "radius": 4.79 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 9.52 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E10")])]});
            deleteBodies(context, id + "F4", {"entities" : qUnion([Q0])});
        }
    });