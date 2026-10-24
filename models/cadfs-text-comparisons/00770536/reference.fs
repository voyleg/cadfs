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
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(0, 719.83) * mm, "construction": true});
            skLineSegment(sketch, "E1", {"start": v(381, 750.81) * mm, "end": v(381, -112.59) * mm, "construction": true});
            skLineSegment(sketch, "E2.bottom", {"start": v(107.95, 0) * mm, "end": v(158.75, 0) * mm});
            skLineSegment(sketch, "E2.top", {"start": v(107.95, 177.8) * mm, "end": v(158.75, 177.8) * mm});
            skLineSegment(sketch, "E2.left", {"start": v(107.95, 0) * mm, "end": v(107.95, 177.8) * mm});
            skLineSegment(sketch, "E2.right", {"start": v(158.75, 0) * mm, "end": v(158.75, 26.68) * mm});
            skLineSegment(sketch, "E3.bottom", {"start": v(304.8, 609.6) * mm, "end": v(355.6, 609.6) * mm});
            skLineSegment(sketch, "E3.top", {"start": v(304.8, 431.8) * mm, "end": v(355.6, 431.8) * mm});
            skLineSegment(sketch, "E3.left", {"start": v(304.8, 609.6) * mm, "end": v(304.8, 582.92) * mm});
            skLineSegment(sketch, "E3.right", {"start": v(355.6, 609.6) * mm, "end": v(355.6, 431.8) * mm});
            skLineSegment(sketch, "E4", {"start": v(184.15, 88.9) * mm, "end": v(184.15, 88.9) * mm});
            skArc(sketch, "E5", {"start": v(168.9, 39.13) * mm, "mid": v(198.1, 56.77) * mm, "end": v(209.55, 88.9) * mm});
            skArc(sketch, "E6", {"start": v(294.64, 570.47) * mm, "mid": v(265.45, 552.83) * mm, "end": v(254, 520.7) * mm});
            skLineSegment(sketch, "E7", {"start": v(209.55, 88.9) * mm, "end": v(209.55, 273.05) * mm});
            skLineSegment(sketch, "E8.trimOffspring", {"start": v(184.15, 273.05) * mm, "end": v(184.15, 88.9) * mm});
            skLineSegment(sketch, "E9", {"start": v(254, 520.7) * mm, "end": v(254, 336.55) * mm});
            skLineSegment(sketch, "E10", {"start": v(279.4, 520.7) * mm, "end": v(279.4, 336.55) * mm});
            skLineSegment(sketch, "E11.trimOffspring", {"start": v(304.8, 520.7) * mm, "end": v(304.8, 431.8) * mm});
            skLineSegment(sketch, "E12.trimOffspring", {"start": v(158.75, 88.9) * mm, "end": v(158.75, 177.8) * mm});
            skLineSegment(sketch, "E13", {"start": v(228.6, 317.5) * mm, "end": v(234.95, 317.5) * mm});
            skLineSegment(sketch, "E14", {"start": v(234.95, 292.1) * mm, "end": v(228.6, 292.1) * mm});
            skPoint(sketch, "E15.visualSharp", {"position": v(209.55, 292.1) * mm});
            skArc(sketch, "E15.filletArc", {"start": v(228.6, 292.1) * mm, "mid": v(215.13, 286.52) * mm, "end": v(209.55, 273.05) * mm});
            skPoint(sketch, "E16.visualSharp", {"position": v(184.15, 317.5) * mm});
            skArc(sketch, "E16.filletArc", {"start": v(228.6, 317.5) * mm, "mid": v(197.17, 304.48) * mm, "end": v(184.15, 273.05) * mm});
            skPoint(sketch, "E17.visualSharp", {"position": v(254, 317.5) * mm});
            skArc(sketch, "E17.filletArc", {"start": v(234.95, 317.5) * mm, "mid": v(248.42, 323.08) * mm, "end": v(254, 336.55) * mm});
            skPoint(sketch, "E18.visualSharp", {"position": v(279.4, 292.1) * mm});
            skArc(sketch, "E18.filletArc", {"start": v(234.95, 292.1) * mm, "mid": v(266.38, 305.12) * mm, "end": v(279.4, 336.55) * mm});
            skPoint(sketch, "E19.visualSharp", {"position": v(158.75, 63.5) * mm});
            skArc(sketch, "E19.filletArc", {"start": v(158.75, 88.9) * mm, "mid": v(171.45, 76.2) * mm, "end": v(184.15, 88.9) * mm});
            skPoint(sketch, "E20.visualSharp", {"position": v(158.75, 38.1) * mm});
            skArc(sketch, "E20.filletArc", {"start": v(168.9, 39.13) * mm, "mid": v(161.61, 34.72) * mm, "end": v(158.75, 26.68) * mm});
            skPoint(sketch, "E21.visualSharp", {"position": v(304.8, 571.5) * mm});
            skArc(sketch, "E21.filletArc", {"start": v(294.64, 570.47) * mm, "mid": v(301.94, 574.88) * mm, "end": v(304.8, 582.92) * mm});
            skArc(sketch, "E22", {"start": v(304.8, 520.7) * mm, "mid": v(292.1, 533.4) * mm, "end": v(279.4, 520.7) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E2.bottom")}),1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0");
            revolve(context, id + "F1", {"surfaceOperationType" : NewSurfaceOperationType.NEW, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.ONE_DIRECTION, "angle" : 270 * degree});
        }
    });