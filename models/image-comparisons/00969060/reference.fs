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
            skLineSegment(sketch, "E0.bottom", {"start": v(101.52, 48.12) * mm, "end": v(-101.52, 48.12) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(101.52, -48.12) * mm, "end": v(-101.52, -48.12) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(101.52, 48.12) * mm, "end": v(101.52, -48.12) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-101.52, 48.12) * mm, "end": v(-101.52, -48.12) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skCircle(sketch, "E1", {"center": v(-93.25, 39.87) * mm, "radius": 8 * mm});
            skCircle(sketch, "E2", {"center": v(93.47, 39.87) * mm, "radius": 8 * mm});
            skCircle(sketch, "E3", {"center": v(93.47, -39.87) * mm, "radius": 8 * mm});
            skCircle(sketch, "E4", {"center": v(-93.25, -39.87) * mm, "radius": 8 * mm});
            skLineSegment(sketch, "E5.bottom", {"start": v(80.67, 34.98) * mm, "end": v(-80.67, 34.98) * mm});
            skLineSegment(sketch, "E5.top", {"start": v(80.67, -34.98) * mm, "end": v(-80.67, -34.98) * mm});
            skLineSegment(sketch, "E5.left", {"start": v(80.67, 34.98) * mm, "end": v(80.67, -34.98) * mm});
            skLineSegment(sketch, "E5.right", {"start": v(-80.67, 34.98) * mm, "end": v(-80.67, -34.98) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 12.7 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4")])],"isStart":false});
            shell(context, id + "F2", {"entities" : qUnion([Q0]), "thickness" : 2.54 * mm});
        }
    });