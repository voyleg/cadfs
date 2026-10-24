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
            skLineSegment(sketch, "E0.bottom", {"start": v(23.12, -20.87) * mm, "end": v(-23.12, -20.87) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(23.12, -36.54) * mm, "end": v(-23.12, -36.54) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(23.12, -20.87) * mm, "end": v(23.12, -36.54) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-23.12, -20.87) * mm, "end": v(-23.12, -36.54) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, -28.7) * mm});
            skLineSegment(sketch, "E1", {"start": v(-43, 0) * mm, "end": v(47.56, 0) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2", {"center": v(0, 53.42) * mm, "radius": 33.7 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F0.wireOp",EDGE,"E1");
            cPlane(context, id + "F2", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.LINE_ANGLE, "offset" : 25 * mm, "angle" : 45 * degree, "width" : 150 * mm, "height" : 150 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F2.planeOp",FACE);
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skEllipse(sketch, "E3", {"center": v(0, 34.14) * mm, "majorRadius": 23.12 * mm, "minorRadius": 14.39 * mm, "majorAxis": v(1, 0)});
            skLineSegment(sketch, "E4", {"start": v(23.12, 34.14) * mm, "end": v(-23.12, 34.14) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            var Q1;
            Q1 = qSketchRegion(id + "F3", true);
            var Q2;
            Q2 = qSketchRegion(id + "F1", true);
            loft(context, id + "F4", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }, { "sheetProfileEntities" : qUnion([Q2]) }]});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.opLoft","CAP_FACE",FACE,{"disambiguationData":[OSD([makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E2")}),1.0]])]})])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F4.opLoft","CAP_FACE",FACE,{"disambiguationData":[OSD([makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),1.0]])]})])],"isStart":true});
            shell(context, id + "F5", {"entities" : qUnion([Q0, Q1]), "thickness" : 1.5 * mm});
        }
    });