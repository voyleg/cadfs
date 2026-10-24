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
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 37.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            cPlane(context, id + "F1", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 177.8 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 37.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            cPlane(context, id + "F3", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 95.25 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F3.planeOp",FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 13.75 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            var Q1;
            Q1 = qSketchRegion(id + "F2", true);
            var Q2;
            Q2 = qSketchRegion(id + "F4", true);
            loft(context, id + "F5", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }, { "sheetProfileEntities" : qUnion([Q2]) }]});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opLoft","CAP_FACE",FACE,{"disambiguationData":[OSD([makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E2")}),1.0]])]})])],"isStart":true});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E3", {"center": v(0, 0) * mm, "radius": 16.5 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F6", true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F7.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F6.wireOp",EDGE,"E3")])],"isStart":false});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E4", {"center": v(0, 0) * mm, "radius": 15 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F8", true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 15 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F10", { "sketchPlane" : qUnion([Q0])});
            skFitSpline(sketch, "E5", {"points": [v(-13.75, 273.05) * mm, v(-23.07, 241.47) * mm, v(-49.29, 152.7) * mm, v(-42.12, 59.83) * mm, v(-37.5, 0) * mm]});
            skFitSpline(sketch, "E6", {"points": [v(37.5, 0) * mm, v(42.12, 59.83) * mm, v(49.29, 152.7) * mm, v(23.07, 241.47) * mm, v(13.75, 273.05) * mm]});
            skCircle(sketch, "E7", {"center": v(40.17, 36) * mm, "radius": 1.5 * mm});
            skLineSegment(sketch, "E8", {"start": v(0, 0) * mm, "end": v(0, 83.81) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F10", true);
            var Q1;
            Q1=sQuery(id+"F10.wireOp",EDGE,"E8");
            revolve(context, id + "F11", {"operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL, "oppositeDirection" : true});
        }
    });