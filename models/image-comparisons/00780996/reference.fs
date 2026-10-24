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
            skLineSegment(sketch, "E0.bottom", {"start": v(-10.23, 5.92) * mm, "end": v(49.77, 5.92) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-10.23, -29.08) * mm, "end": v(49.77, -29.08) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-15.23, 0.92) * mm, "end": v(-15.23, -24.08) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(54.77, 0.92) * mm, "end": v(54.77, -24.08) * mm});
            skPoint(sketch, "E1.visualSharp", {"position": v(-15.23, -29.08) * mm});
            skArc(sketch, "E1.filletArc", {"start": v(-15.23, -24.08) * mm, "mid": v(-13.77, -27.61) * mm, "end": v(-10.23, -29.08) * mm});
            skPoint(sketch, "E2.visualSharp", {"position": v(-15.23, 5.92) * mm});
            skArc(sketch, "E2.filletArc", {"start": v(-10.23, 5.92) * mm, "mid": v(-13.77, 4.46) * mm, "end": v(-15.23, 0.92) * mm});
            skPoint(sketch, "E3.visualSharp", {"position": v(54.77, 5.92) * mm});
            skArc(sketch, "E3.filletArc", {"start": v(54.77, 0.92) * mm, "mid": v(53.3, 4.46) * mm, "end": v(49.77, 5.92) * mm});
            skPoint(sketch, "E4.visualSharp", {"position": v(54.77, -29.08) * mm});
            skArc(sketch, "E4.filletArc", {"start": v(49.77, -29.08) * mm, "mid": v(53.3, -27.61) * mm, "end": v(54.77, -24.08) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 5 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right"),sQuery(id+"F0.wireOp",EDGE,"E1.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E2.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E3.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E4.filletArc")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E5", {"center": v(-7.98, -11.43) * mm, "radius": 3.22 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E5")}),1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])],"isStart":true});
            fillet(context, id + "F4", {"entities" : qUnion([Q0, Q1]), "radius" : 2 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F3.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E5")])],"isStart":true})});
            var Q1;
            Q1=makeQuery(id+"F3.boolean.opBoolean","INTERSECT",EDGE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right"),sQuery(id+"F0.wireOp",EDGE,"E1.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E2.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E3.filletArc"),sQuery(id+"F0.wireOp",EDGE,"E4.filletArc")])],"isStart":true}),makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E5")])]})]});
            chamfer(context, id + "F5", {"entities" : qUnion([Q0, Q1]), "width" : 2 * mm, "tangentPropagation" : true});
        }
    });