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
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(38.1, 0) * mm, "construction": true});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 2.032 * mm});
            skCircle(sketch, "E2", {"center": v(38.1, 0) * mm, "radius": 2.032 * mm});
            skArc(sketch, "E3", {"start": v(27.178, 12.891594781096712) * mm, "mid": v(19.05, 15.24) * mm, "end": v(10.922, 12.891594781096714) * mm});
            skArc(sketch, "E4", {"start": v(40.809333333333335, -4.29719826036557) * mm, "mid": v(43.18, 0) * mm, "end": v(40.80933333333333, 4.297198260365574) * mm});
            skArc(sketch, "E5", {"start": v(10.922, -12.891594781096712) * mm, "mid": v(19.05, -15.24) * mm, "end": v(27.178, -12.891594781096709) * mm});
            skArc(sketch, "E6", {"start": v(-2.7093333333333316, 4.297198260365572) * mm, "mid": v(-5.08, 0) * mm, "end": v(-2.709333333333332, -4.297198260365571) * mm});
            skLineSegment(sketch, "E7", {"start": v(27.178, 12.891594781096716) * mm, "end": v(40.80933333333333, 4.297198260365576) * mm});
            skLineSegment(sketch, "E8", {"start": v(27.178, -12.891594781096703) * mm, "end": v(40.80933333333333, -4.297198260365561) * mm});
            skLineSegment(sketch, "E9", {"start": v(10.922, 12.891594781096718) * mm, "end": v(-2.7093333333333343, 4.297198260365568) * mm});
            skLineSegment(sketch, "E10", {"start": v(-2.709333333333332, -4.297198260365573) * mm, "end": v(10.922, -12.89159478109671) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 1.5875 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4"),sQuery(id+"F0.wireOp",EDGE,"E5"),sQuery(id+"F0.wireOp",EDGE,"E6"),sQuery(id+"F0.wireOp",EDGE,"E7"),sQuery(id+"F0.wireOp",EDGE,"E8"),sQuery(id+"F0.wireOp",EDGE,"E9"),sQuery(id+"F0.wireOp",EDGE,"E10")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E11", {"center": v(19.05, 0) * mm, "radius": 15.24 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F2",true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 10.7315 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E11")])],"isStart":false});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E12", {"center": v(19.05, 0) * mm, "radius": 8.001 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F4",true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 8.001 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E12")])],"isStart":false});
            fillet(context, id + "F6", {"entities" : qUnion([Q0]), "radius" : 8.001 * mm, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E11")])],"isStart":false});
            chamfer(context, id + "F7", {"entities" : qUnion([Q0]), "width" : 5.6515 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F2.wireOp",EDGE,"E11");Q0=makeQuery(id+"F7.opChamfer","BLEND_EDGE",EDGE,{"blendedFrom":[makeQuery(id+"F3.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([subQ0])],"isStart":false}),makeQuery(id+"F3.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])]}),makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5")])]}),makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ0])]})]})],"blendedInto":[makeQuery(id+"F3.boolean.opBoolean","MERGE",FACE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])]}),makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5")])]}),makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ0])]})]})]});}
            fillet(context, id + "F8", {"entities" : qUnion([Q0]), "radius" : 3.175 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });