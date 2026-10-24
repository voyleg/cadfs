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
            skLineSegment(sketch, "E0.bottom", {"start": v(30, -15) * mm, "end": v(-30, -15) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(30, 15) * mm, "end": v(-30, 15) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(30, -15) * mm, "end": v(30, 15) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-30, -15) * mm, "end": v(-30, 15) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 6 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "radius" : 5 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            shell(context, id + "F3", {"entities" : qUnion([Q0]), "thickness" : 1.2 * mm});
        }
    });