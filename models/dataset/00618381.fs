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
            skLineSegment(sketch, "E0", {"start": v(-31.144350068193525, 48.24588724580232) * mm, "end": v(-31.144350068193518, -35.307444632053375) * mm});
            skLineSegment(sketch, "E1", {"start": v(-20.911704748868942, 48.24588724580233) * mm, "end": v(-20.911704748868942, -35.307444632053375) * mm});
            skLineSegment(sketch, "E2", {"start": v(-31.144350068193514, -42.88414865732193) * mm, "end": v(-31.144350068193514, -53.732629865407944) * mm});
            skLineSegment(sketch, "E3", {"start": v(-20.911704748868942, -42.88414865732193) * mm, "end": v(-20.911704748868942, -53.73262986540794) * mm});
            skArc(sketch, "E4", {"start": v(-31.144350068193518, -35.307444632053375) * mm, "mid": v(-36.784050523524265, -44.52003724873066) * mm, "end": v(-31.144350068193514, -53.732629865407944) * mm});
            skArc(sketch, "E5", {"start": v(-20.911704748868942, -53.732629865407944) * mm, "mid": v(-15.346972319279539, -44.52003724873066) * mm, "end": v(-20.911704748868942, -35.307444632053375) * mm});
            skLineSegment(sketch, "E6", {"start": v(-31.144350068193514, -42.88414865732193) * mm, "end": v(-20.911704748868942, -42.88414865732193) * mm});
            skCircle(sketch, "E7", {"center": v(-25.561498478055, 58.14605578780174) * mm, "radius": 11.365807012153036 * mm});
            skCircle(sketch, "E8.cCircle", {"center": v(-25.561498478055, 58.14605578780174) * mm, "radius": 6.956026485065281 * mm, "construction": true});
            skLineSegment(sketch, "E8.0", {"start": v(-25.779754934906194, 66.17521743355378) * mm, "end": v(-18.71716875016766, 62.34965224685088) * mm});
            skLineSegment(sketch, "E8.1", {"start": v(-18.71716875016766, 62.34965224685088) * mm, "end": v(-18.498912293316465, 54.32049060109884) * mm});
            skLineSegment(sketch, "E8.2", {"start": v(-18.498912293316465, 54.32049060109884) * mm, "end": v(-25.343242021203803, 50.1168941420497) * mm});
            skLineSegment(sketch, "E8.3", {"start": v(-25.343242021203803, 50.1168941420497) * mm, "end": v(-32.405828205942335, 53.942459328752605) * mm});
            skLineSegment(sketch, "E8.4", {"start": v(-32.405828205942335, 53.942459328752605) * mm, "end": v(-32.62408466279354, 61.97162097450464) * mm});
            skLineSegment(sketch, "E8.5", {"start": v(-32.62408466279354, 61.97162097450464) * mm, "end": v(-25.779754934906194, 66.17521743355378) * mm});
            skPoint(sketch, "E8.0.midPoint", {"position": v(-22.248461842536926, 64.26243484020233) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 8.382 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])],"isStart":true});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2]), "radius" : 2.452840979371065 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5")])],"isStart":true});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4")])],"isStart":true});
            fillet(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "radius" : 2.2075568814339586 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7")])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7")])],"isStart":false});
            fillet(context, id + "F4", {"entities" : qUnion([Q0, Q1]), "radius" : 3.0660512242138314 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4"),sQuery(id+"F0.wireOp",EDGE,"E5"),sQuery(id+"F0.wireOp",EDGE,"E6"),sQuery(id+"F0.wireOp",EDGE,"E7"),sQuery(id+"F0.wireOp",EDGE,"E8.0"),sQuery(id+"F0.wireOp",EDGE,"E8.1"),sQuery(id+"F0.wireOp",EDGE,"E8.2"),sQuery(id+"F0.wireOp",EDGE,"E8.3"),sQuery(id+"F0.wireOp",EDGE,"E8.4"),sQuery(id+"F0.wireOp",EDGE,"E8.5")])],"isStart":false});
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skText(sketch, "E9", { "text": "7/16", "fontName": "OpenSans-Regular.ttf"});
            const initialGuessF5  = {"E9": [-0.03231, -0.04294, 1, 0, 0.00423]};
            skSetInitialGuess(sketch, initialGuessF5);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F5", true);
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 1.016 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":true});
            fillet(context, id + "F7", {"entities" : qUnion([Q0]), "radius" : 1.287741514169809 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });