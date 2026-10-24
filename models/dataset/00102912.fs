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
            skArc(sketch, "E0", {"start": v(0.8604812044142783, 82.04641136990038) * mm, "mid": v(5.344160844123825, 95.95314579631085) * mm, "end": v(-7.999999984507648, 90.00049787308598) * mm});
            skArc(sketch, "E1", {"start": v(-8.005601087720699, 0) * mm, "mid": v(-0.006410582799067701, -8.113803628990954) * mm, "end": v(7.99277992212258, 0) * mm});
            skLineSegment(sketch, "E2", {"start": v(-8.005601087720697, 0) * mm, "end": v(-7.999999984507646, 90.00049787308598) * mm});
            skLineSegment(sketch, "E3", {"start": v(7.992779922122578, 0) * mm, "end": v(7.992779922122578, 63.68499994277954) * mm});
            skArc(sketch, "E4", {"start": v(0.8604812044142804, 82.04641136990038) * mm, "mid": v(0.9131613495869227, 71.5009351937363) * mm, "end": v(7.992779922122578, 63.68499994277954) * mm});
            skLineSegment(sketch, "E5.trimOffspring", {"start": v(7.992779922122578, 89.66019253022603) * mm, "end": v(7.992779922122578, 90) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4")])],"isStart":false});
            fillet(context, id + "F2", {"entities" : qUnion([Q0]), "radius" : 3 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":false});
            fillet(context, id + "F3", {"entities" : qUnion([Q0, Q1]), "radius" : 1 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4")])]});
            transform(context, id + "F4", {"entities" : qUnion([Q0]), "transformType" : TransformType.TRANSLATION_3D, "dx" : 0 * mm, "dy" : 0 * mm, "dz" : 0 * mm, "makeCopy" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.opPattern","COPY",BODY,{"derivedFrom":makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4")])]}),"instanceName":"1"});
            var Q1;
            Q1=qCreatedBy(makeId("Top.planeOp"),FACE);
            mirror(context, id + "F5", {"operationType" : NewBodyOperationType.ADD, "entities" : qUnion([Q0]), "mirrorPlane" : qUnion([Q1])});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4")])]});
            transform(context, id + "F6", {"entities" : qUnion([Q0]), "transformType" : TransformType.TRANSLATION_3D, "dx" : 0 * mm, "dy" : 0 * mm, "dz" : 10 * mm, "makeCopy" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4")])]});
            var Q1;
            Q1=qCreatedBy(makeId("Top.planeOp"),FACE);
            mirror(context, id + "F7", {"entities" : qUnion([Q0]), "mirrorPlane" : qUnion([Q1])});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E6", {"start": v(-7.9284372760879664, 0) * mm, "mid": v(0, -7.9284372760879664) * mm, "end": v(7.9284372760879664, 0) * mm});
            skLineSegment(sketch, "E7", {"start": v(-7.9284372760879664, 0) * mm, "end": v(-7.9284372760879664, 89.72339332103729) * mm});
            skLineSegment(sketch, "E8", {"start": v(-7.9284372760879664, 89.72339332103729) * mm, "end": v(-5.350940127810754, 75.25295037236627) * mm});
            skLineSegment(sketch, "E9", {"start": v(-5.350940127810754, 75.25295037236627) * mm, "end": v(-5.350940127810754, 63.4736493229866) * mm});
            skLineSegment(sketch, "E10", {"start": v(7.9284372760879664, 0) * mm, "end": v(-5.350940127810754, 63.4736493229866) * mm});
            skPoint(sketch, "E11.trimOffspring.end.orphan", {"position": v(-5.350940127810754, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F8", true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "depth" : 2 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F10", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E12", {"start": v(7.52030437960685, 90.00761806964874) * mm, "mid": v(0.3010957775663673, 97.5218924387855) * mm, "end": v(-7.496194007820799, 90.60932676914172) * mm});
            skLineSegment(sketch, "E13", {"start": v(7.520304379606849, 16.97489619255066) * mm, "end": v(-6.661958032283194, 86.51859340105847) * mm});
            skLineSegment(sketch, "E14", {"start": v(7.520304379606852, 90.00761806964874) * mm, "end": v(16.47827960550785, 74.85455274581909) * mm});
            skLineSegment(sketch, "E15", {"start": v(16.47827960550785, 74.85455274581909) * mm, "end": v(7.520304379606854, 16.974896192550677) * mm});
            skArc(sketch, "E16", {"start": v(7.517117864041455, 71.69038520943603) * mm, "mid": v(9.35875565190372, 71.67861807811994) * mm, "end": v(10.969243380205784, 72.57198109730648) * mm});
            skLineSegment(sketch, "E17", {"start": v(10.969243380205786, 72.57198109730648) * mm, "end": v(11.681053275786596, 76.8726378127055) * mm});
            skLineSegment(sketch, "E18", {"start": v(11.681053275786596, 76.8726378127055) * mm, "end": v(9.207497790535603, 78.7495084975763) * mm});
            skLineSegment(sketch, "E19", {"start": v(4.9078008403001165, 74.4471121284269) * mm, "end": v(7.517117864041452, 71.69038520943603) * mm});
            skLineSegment(sketch, "E20", {"start": v(5.602399228743426, 77.43572364732603) * mm, "end": v(4.9078008403001165, 74.4471121284269) * mm});
            skArc(sketch, "E21.trimOffspring", {"start": v(9.207497790535601, 78.7495084975763) * mm, "mid": v(7.217220864456036, 78.60775115224043) * mm, "end": v(5.602399228743428, 77.43572364732603) * mm});
            skPoint(sketch, "E22.start.orphan", {"position": v(-4.353000839423868, 75.19646331883727) * mm});
            skCircle(sketch, "E23", {"center": v(0, 90.00761806964874) * mm, "radius": 7.52030437960685 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F10", true);
            extrude(context, id + "F11", {"entities" : qUnion([Q0]), "depth" : 2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F11.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F10.wireOp",EDGE,"E13")])],"isStart":false});
            chamfer(context, id + "F12", {"entities" : qUnion([Q0]), "chamferType" : ChamferType.TWO_OFFSETS, "width1" : 2 * mm, "oppositeDirection" : false, "width2" : 8 * mm});
        }
    });