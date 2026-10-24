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
            skLineSegment(sketch, "E0.bottom", {"start": v(50, 20) * mm, "end": v(-50, 20) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(50, -20) * mm, "end": v(-50, -20) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(50, 20) * mm, "end": v(50, -20) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-50, 20) * mm, "end": v(-50, -20) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 3 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skText(sketch, "E1", { "text": "PATRICK", "fontName": "OpenSans-BoldItalic.ttf"});
            skText(sketch, "E2", { "text": "ÉLECTRIQUE", "fontName": "OpenSans-BoldItalic.ttf"});
            const initialGuessF2  = {"E1": [-0.02662, 0.00651, 1, 0, 0.01], "E2": [-0.03724, -0.00264, 1, 0, 0.008]};
            skSetInitialGuess(sketch, initialGuessF2);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E0.left");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E0.top");var subQ2=sQuery(id+"F0.wireOp",EDGE,"E0.right");var subQ3=sQuery(id+"F0.wireOp",EDGE,"E0.bottom");Q0=makeQuery(id+"F3.boolean.opBoolean","SPLIT",FACE,{"disambiguationData":[TD([makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ3])]})])],"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([subQ3,subQ1,subQ0,subQ2])],"isStart":false})});}
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E3", {"start": v(-37.73, -5.62) * mm, "end": v(25.46, -5.62) * mm});
            skLineSegment(sketch, "E4", {"start": v(25.46, -5.62) * mm, "end": v(19.77, -12.33) * mm});
            skLineSegment(sketch, "E5", {"start": v(19.77, -12.33) * mm, "end": v(43.78, -16.06) * mm});
            skLineSegment(sketch, "E6", {"start": v(43.78, -16.06) * mm, "end": v(8.32, -16.06) * mm});
            skLineSegment(sketch, "E7", {"start": v(8.32, -16.06) * mm, "end": v(12.62, -10.24) * mm});
            skLineSegment(sketch, "E8", {"start": v(12.62, -10.24) * mm, "end": v(-37.73, -5.62) * mm});
            skLineSegment(sketch, "E9", {"start": v(-37.73, -5.62) * mm, "end": v(-39.74, -7.41) * mm});
            skLineSegment(sketch, "E10", {"start": v(-39.74, -7.41) * mm, "end": v(9.08, -11.73) * mm});
            skLineSegment(sketch, "E11", {"start": v(9.08, -11.73) * mm, "end": v(4.86, -18.16) * mm});
            skLineSegment(sketch, "E12", {"start": v(4.86, -18.16) * mm, "end": v(41.97, -18.16) * mm});
            skLineSegment(sketch, "E13", {"start": v(41.97, -18.16) * mm, "end": v(43.78, -16.06) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E6")}),1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 1.2 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E3")}),-1.0]])]});
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2.2 * mm, "offsetDistance" : 25 * mm});
        }
    });