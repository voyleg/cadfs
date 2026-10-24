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
            skLineSegment(sketch, "E0.bottom", {"start": v(-45.51680013537407, 26.907065883278847) * mm, "end": v(62.111467123031616, 26.907065883278847) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-45.51680013537407, -42.31639951467514) * mm, "end": v(62.111467123031616, -42.31639951467514) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-45.51680013537407, 26.907065883278847) * mm, "end": v(-45.51680013537407, -42.31639951467514) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(62.111467123031616, 26.907065883278847) * mm, "end": v(62.111467123031616, -42.31639951467514) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 76.2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])]});
            shell(context, id + "F2", {"entities" : qUnion([Q0]), "thickness" : 12.7 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1", {"start": v(0, 27.381200343370438) * mm, "end": v(41.72373190522194, 75.03160089254379) * mm});
            skArc(sketch, "E2", {"start": v(0, 27.38120034337044) * mm, "mid": v(45.35369396005723, 29.76082085631497) * mm, "end": v(41.72373190522194, 75.03160089254379) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F3", true);
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "endBound" : BoundingType.UP_TO_SURFACE, "endBoundEntityFace" : qUnion([Q1]), "depth" : 25.4 * mm, "hasSecondDirection" : true, "secondDirectionBound" : SecondDirectionBoundingType.UP_TO_SURFACE, "secondDirectionOppositeDirection" : true, "secondDirectionBoundEntityFace" : qUnion([Q2]), "secondDirectionDepth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F3.wireOp",EDGE,"E1")])]});
            shell(context, id + "F5", {"entities" : qUnion([Q0]), "thickness" : 2.54 * mm});
        }
    });